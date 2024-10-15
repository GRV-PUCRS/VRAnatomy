using UnityEngine;

/* Raycasting
 * Creates a raycast from the object.
 * 
 * Class reviewed by Leonardo Pavanatto on 05/2019.
 */
public class Raycasting : MonoBehaviour
{
    [SerializeField]
    private GameObject info;

    // Interacting objects
    private float distance = 20.0f;
    private GameObject viewed = null;
    private GameObject selected = null;
    private Vector3 hitpoint = Vector3.zero;

    // Layers to ignore (9 and 2)
    private LayerMask mask = ~(1 << 9) & ~(1 << 2);

    //============================================================================

    /* Update is called once per frame */
    void Update()
    {
        RaycastHit hit;

        if (selected) return;

        if (!transform.GetComponent<LineRenderer>().enabled)
            transform.GetComponent<LineRenderer>().enabled = true;

        // Looks for a collision with relevant objects
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, mask))
        {
            PaintRay(Color.red);
            hitpoint = hit.point;
            viewed = hit.collider.gameObject;
            distance = Vector3.Distance(hit.transform.position, transform.position);
        }
        else
            PaintRay(Color.white);
    }

    /* Paint the line renderer with a given color */
    private void PaintRay(Color color)
    {
        transform.GetComponent<LineRenderer>().startColor = transform.GetComponent<LineRenderer>().endColor = color;
    }

    /* Performs selection and release operations on click */
    public void SelectRelease()
    {
        // If selected, we release it
        if (selected)
        {
            selected = viewed = null;
            hitpoint = Vector3.zero;

            return;
        }

        // If in view, we select it
        if (viewed)
        {
            selected = viewed;
        }
    }
}
