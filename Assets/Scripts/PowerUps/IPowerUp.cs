﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPowerUp
{
    void Activate();
    void Deactivate();
    IEnumerator HoldActive();
}
