using UnityEngine ;
using System . Collections ;
public class PlayerControl : MonoBehaviour {
	protected Animator animator ;
	private float directionX = 0 ;
	private float directionY = 0 ;
	private bool isWalk = false ;
	public bool isAttacked = false;
	public bool isAttack = false;
	public GameObject other;

	void Start () {
		animator = GetComponent < Animator > ();
	}
	void Update () {
		if ( animator )
		{
			float h = Input . GetAxisRaw ( "Horizontal" );
			float v = Input . GetAxisRaw ( "Vertical" );
			isWalk = true ;

			if ( h > 0 ) {
				directionX = 1 ;
				directionY = 0 ;
			} 
			else if ( h < 0 ) {
				directionX = - 1 ;
				directionY = 0 ;
			}
			else if ( v > 0 ) 
			{
				directionX = 0 ;
				directionY = 1 ;
			} 
			else if ( v < 0 ) 
			{
				directionX = 0 ;
				directionY = - 1 ;
			} 
			else {
				isWalk = false;
			}

			if ( isWalk ) {
				transform . Translate ( new Vector3 ( directionX , directionY , 0 ) * Time . deltaTime * 3f );
				isAttacked = false;
			}

			CharacterMove cm = other.GetComponent<CharacterMove> ();
			if (cm.hp == 0) {
				isWalk = false;
				isAttacked = false;
				isAttack = false;
			}

			if (cm.isDamaged == true) {
				isAttacked = true;
			} else {
				isAttacked = false;
			}

			if (cm.isClicked == true) {
				isAttack = true;
				//isWalk = false;
			} else {
				isAttack = false;
			}
			animator.SetFloat ( "directionX" , directionX );
			animator.SetFloat ( "directionY" , directionY );
			animator.SetBool ("isWalk" , isWalk );
			animator.SetBool ("isAttacked", isAttacked);
		}
	}
}

