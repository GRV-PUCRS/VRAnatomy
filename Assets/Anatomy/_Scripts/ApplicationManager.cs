using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplicationManager : Singleton<ApplicationManager>
{
    [SerializeField] private Transform anatomy;
    [SerializeField] private Transform body;

    [SerializeField] private GameObject _scene2Prefab;
    [SerializeField] private GameObject _scene2Instance;
    [SerializeField] private Transform _scene2Parent;

    private void Update()
    {
        anatomy.transform.position = body.transform.position;
        anatomy.transform.rotation = body.transform.rotation;
    }

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ResetScene2()
    {
        Destroy(_scene2Instance);

        _scene2Instance = Instantiate(_scene2Prefab, _scene2Parent);
    }
}
