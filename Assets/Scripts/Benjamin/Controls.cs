using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controls : MonoBehaviour
{
    // Player (Gameplay) prob garbage code
    public InputActionReference m_MoveUp;public InputActionReference m_MoveDown;public InputActionReference m_MoveLeft;public InputActionReference m_MoveRight;public InputActionReference m_Interact;public InputActionReference m_OpenUI;


    // Player (Menu) 
    public InputActionReference m_MenuUp;public InputActionReference m_MenuDown;public InputActionReference m_MenuSelect;public InputActionReference m_MenuReturn;public InputActionReference m_CloseUI;

    /* Work In Progress for later
    void RebindActionKey() 
    {
    }
    */
}
