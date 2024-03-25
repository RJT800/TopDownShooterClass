using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarUIBehavior : MonoBehaviour
{
    [SerializeField]
    private RawImage _healthBarFG;

    [SerializeField]
    private HealthBehaviour _healthBehavior;

    private float _maxHealth;

    

    private void Start()
    {
        Debug.Assert(_healthBarFG);
        Debug.Assert(_healthBehavior);
    }

    private void Update()
    {
        //guard clause
        if (_healthBarFG == null || _healthBehavior == null)
            return;

        float health = _healthBehavior.Health;



        //min of 1 to ensure no dividing by zero or negative numbers
        float maxHealth = Mathf.Max(1, _healthBehavior.MaxHealth);

        //get health as value between 0-1
        float healthPercentage = Mathf.Clamp01(health / maxHealth);

        //set health bar scale
        Vector3 newScale = _healthBarFG.rectTransform.localScale;
        newScale.x = healthPercentage;
        _healthBarFG.rectTransform.localScale = newScale;


        
    }
}
