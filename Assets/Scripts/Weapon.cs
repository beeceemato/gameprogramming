using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter {
	public class Weapon : MonoBehaviour {

		[SerializeField]
		private float _cooldownTime = 0.5f;
		[SerializeField]
		private Projectile _projectilePrefab;

		// Variable for counting how long ago projectile was launched
		private float _timeSinceShot = 0;
		private bool _isInCooldown = false;

		public bool Shoot() {
			if (_isInCooldown) {
				return false;
			}

			Projectile projectile = Instantiate (_projectilePrefab, transform.position, transform.rotation);
			projectile.Launch (transform.up);

			// Go to cooldown phase
			_isInCooldown = true;
			// Reset timer
			_timeSinceShot = 0;

			return true;
		}
		
		// Update is called once per frame
		void Update () {
			// If we are in cooldown
			if (_isInCooldown) {
				
				// Adds to the time counter
				_timeSinceShot += Time.deltaTime;

				// If the cooldown should stop
				if (_timeSinceShot >= _cooldownTime) {
					_isInCooldown = false;
				}
			}
		}
	}
}