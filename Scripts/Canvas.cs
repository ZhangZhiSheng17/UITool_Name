using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
public class Canvas : MonoBehaviour
{
//auto
    private Text Txt = null;
	

   public void Start()
	{
		Txt = gameObject.transform.Find("/Canvas/Txt").GetComponent<Text>();
		
	}
}
