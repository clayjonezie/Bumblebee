﻿using Bumblebee.Interfaces.Generic;
using OpenQA.Selenium;

namespace Bumblebee.Implementation.Generic
{
    public class TextField<TResult> : Element, ITextField<TResult> where TResult : Block
    {
        public TextField(Block parent, By by)
            : base(parent, by)
        {
        }

        public TextField(Block parent, IWebElement element)
            : base(parent, element)
        {
        }

        public TResult EnterText(string text)
        {
            Tag.SendKeys(text);
            return Session.CurrentBlock<TResult>(ParentElement);
        }
    }
}