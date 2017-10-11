﻿using System;
using OpenQA.Selenium.Remote;
using SauceryX.Capabilities.Base;
using SauceryX.OnDemand;
using SauceryX.Util;

namespace SauceryX.Capabilities.ConcreteProducts {
    internal class WebDriverAndroidCapabilities : BaseCapabilities {
        public WebDriverAndroidCapabilities(SaucePlatform platform, string testName)
            : base(testName)
        {
            Console.WriteLine(SauceryConstants.SETTING_UP, testName, SauceryConstants.ANDROID_ON_WEBDRIVER);
            Caps = DesiredCapabilities.Android();
            Caps.SetCapability(SauceryConstants.SAUCE_PLATFORM_CAPABILITY, SauceryConstants.LINUX);
            Caps.SetCapability(SauceryConstants.SAUCE_VERSION_CAPABILITY, platform.BrowserVersion);
            Caps.SetCapability(SauceryConstants.SAUCE_DEVICE_NAME_CAPABILITY, platform.LongName);
            Caps.SetCapability(SauceryConstants.SAUCE_DEVICE_ORIENTATION_CAPABILITY, platform.DeviceOrientation);

            AddSauceLabsCapabilities();
        }
    }
}
/*
 * Copyright Andrew Gray, Full Circle Solutions
 * Date: 10th September 2014
 * 
 */