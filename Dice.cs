using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

    /// <summary>
    /// Class describing the work of the cube
    /// </summary>
    public class Dice : MonoBehaviour
    {
        private Image side_dice;
        private Animator animator;
        public List<Sprite> sides_dice = new List<Sprite>();
        int index;

        /// <summary>
        /// The method that starts at startup and assigns to fields
        /// </summary>
        private void Start()
        {
            side_dice = this.GetComponent<Image>();
            animator = this.GetComponent<Animator>();
        }

        private void Update()
        {

        }
    /// <summary>
    /// The method randomly generates a number, starts the animation, and calls the “play” coroutine, passing it the generated number in the argument.
    /// </summary>
    public void number_generation()
        {
            int index = Random.Range(0, 6);
            animator.enabled = true;
            StartCoroutine(play(index));
        }
    /// <summary>
    /// Corutin working 5.4 seconds, after which he stops the animation and changes the sprite of the cube to randomly generated
    /// </summary>
    /// <param name="index"></param>
    /// <returns>new WaitForSeconds(5.4f)</returns>
    private IEnumerator<WaitForSeconds> play(int index)
        {
            yield return new WaitForSeconds(5.4f);
            animator.enabled = false;
            side_dice.sprite = sides_dice[index];
        }
    }
