﻿using UnityEngine;

namespace Silicom.Client
{
    public abstract class SilicomEquipment : MonoBehaviour
    {
        public abstract void Initialize(SilicomData[] data);
        public abstract void ReceiveData(SilicomData data);
        public abstract void SendData(SilicomData data);
    }
}