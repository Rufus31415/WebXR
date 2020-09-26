// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Rufus31415.WebXR;
using UnityEngine;

namespace XRTK.WebXR.Plugins
{
    public static class WebXRAPI
    {
        private static SimpleWebXR _instance;

        // Get the xr session MonoBehavior or create it
        public static SimpleWebXR GetSession()
        {
            if (_instance) return _instance;

            var instance = SimpleWebXR.GetInstance();

            if (instance)
            {
                _instance = instance;
                return instance;
            }

            var gameObject = new GameObject("WebXR");
            _instance = gameObject.AddComponent<SimpleWebXR>();
            return _instance;
        }
    }
}
