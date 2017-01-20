﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayIM.Container
{
    public sealed class LayIMGlobalServiceContainer : ServiceProvider
    {
        private static LayIMGlobalServiceContainer _container;
        private static object _lock = new object();
        public static IServiceContainer GlobalContainer
        {
            get
            {
                if (_container == null) {
                    lock (_lock) {
                        if (_container == null) {
                            _container = new LayIMGlobalServiceContainer();
                        }
                    }
                }
                return _container;
            }
        }
    }
}