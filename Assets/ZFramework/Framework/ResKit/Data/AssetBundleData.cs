﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZFramework
{
    public class AssetBundleData 
    {
        public string Name;

        public List<AssetData> AssetDataList = new List<AssetData>();

        public string[] dependencyBundleNames;
    }
}