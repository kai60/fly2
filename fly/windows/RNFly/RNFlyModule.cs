using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Fly.RNFly
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNFlyModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNFlyModule"/>.
        /// </summary>
        internal RNFlyModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNFly";
            }
        }
    }
}
