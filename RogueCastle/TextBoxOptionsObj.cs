﻿// 
// RogueLegacyArchipelago - TextBoxOptionsObj.cs
// Last Modified 2021-12-23
// 
// This project is based on the modified disassembly of Rogue Legacy's engine, with permission to do so by its
// original creators. Therefore, former creators' copyright notice applies to the original disassembly.
// 
// Original Disassembled Source - © 2011-2015, Cellar Door Games Inc.
// Rogue Legacy™ is a trademark or registered trademark of Cellar Door Games Inc. All Rights Reserved.
// 

using System;
using System.Linq;
using DS2DEngine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Tweener.Ease;

namespace RogueCastle
{
    public class TextBoxOptionsObj : ArchipelagoOptionsObj
    {
        private string m_currentValue = string.Empty;
        private string m_placeholder;
        private KeyboardState m_keyboardState;
        private TextObj m_toggleText;

        public TextBoxOptionsObj(ArchipelagoScreen parentScreen, string name, string placeholder) : base(parentScreen, name)
        {
            m_placeholder = placeholder;

            // Toggle Text Highlighting.
            m_toggleText = m_nameText.Clone() as TextObj;
            m_toggleText.X = m_optionsTextOffset;
            m_toggleText.Text = m_placeholder;
            m_toggleText.TextureColor = Color.Gray;

            base.AddChild(m_toggleText);
        }

        public string GetValue
        {
            get { return m_currentValue; }
        }

        public override bool IsActive
        {
            get { return base.IsActive; }
            set
            {
                base.IsActive = value;
                if (value)
                {
                    m_toggleText.TextureColor = Color.Yellow;
                    return;
                }

                m_toggleText.TextureColor = m_currentValue.Length == 0 ? Color.Gray : Color.White;
            }
        }

        public override void Initialize()
        {
            m_currentValue = string.Empty;
            m_keyboardState = Keyboard.GetState();
            base.Initialize();
        }

        public override void HandleInput()
        {
            var currentKeyboardState = Keyboard.GetState();
            var pressedKeys = currentKeyboardState.GetPressedKeys();

            foreach (var key in pressedKeys)
            {
                if (m_keyboardState.IsKeyUp(key))
                {
                    switch (key)
                    {
                        // Backspace key, obviously.
                        case Keys.Back:
                            if (m_currentValue.Length != 0)
                                m_currentValue = m_currentValue.Remove(m_currentValue.Length - 1, 1);
                            break;

                        // Add a space.
                        case Keys.Space:
                            m_currentValue += " ";
                            break;

                        // Exit option.
                        case Keys.Enter:
                        case Keys.Escape:
                        case Keys.Up:
                        case Keys.Down:
                            IsActive = false;
                            break;

                        case Keys.A:
                        case Keys.B:
                        case Keys.C:
                        case Keys.D:
                        case Keys.E:
                        case Keys.F:
                        case Keys.G:
                        case Keys.H:
                        case Keys.I:
                        case Keys.J:
                        case Keys.K:
                        case Keys.L:
                        case Keys.M:
                        case Keys.N:
                        case Keys.O:
                        case Keys.P:
                        case Keys.Q:
                        case Keys.R:
                        case Keys.S:
                        case Keys.T:
                        case Keys.U:
                        case Keys.V:
                        case Keys.W:
                        case Keys.X:
                        case Keys.Y:
                        case Keys.Z:
                            m_currentValue += HandleShift(pressedKeys, key.ToString(), key.ToString().ToLower());
                            break;

                        case Keys.OemPeriod:
                            m_currentValue += HandleShift(pressedKeys, ">", ".");
                            break;

                        case Keys.OemSemicolon:
                            m_currentValue += HandleShift(pressedKeys, ":", ";");
                            break;

                        case Keys.OemComma:
                            m_currentValue += HandleShift(pressedKeys, "<", ",");
                            break;

                        case Keys.OemQuotes:
                            m_currentValue += HandleShift(pressedKeys, "\"", "'");
                            break;

                        case Keys.D0:
                        case Keys.D1:
                        case Keys.D2:
                        case Keys.D3:
                        case Keys.D4:
                        case Keys.D5:
                        case Keys.D6:
                        case Keys.D7:
                        case Keys.D8:
                        case Keys.D9:
                            m_currentValue += key.ToString().Remove(0, 1);
                            break;
                    }
                }
            }

            // Update keyboard state.
            m_keyboardState = currentKeyboardState;

            // Update colors.
            if (IsActive)
            {
                m_toggleText.TextureColor = Color.Yellow;
                m_toggleText.Text = m_currentValue;
            }
            else
            {
                // Remove any trailing whitespace.
                m_currentValue = m_currentValue.Trim();

                if (m_currentValue.Length == 0)
                {
                    m_toggleText.Text = m_placeholder;
                    m_toggleText.TextureColor = Color.Gray;
                }
                else
                {
                    m_toggleText.Text = m_currentValue;
                    m_toggleText.TextureColor = Color.White;
                }
            }

            base.HandleInput();
        }

        private string HandleShift(Keys[] keys, string uppercase, string lowercase)
        {
            if (keys.Contains(Keys.LeftShift) || keys.Contains(Keys.RightShift))
                return uppercase;

            return lowercase;
        }

        public override void Dispose()
        {
            if (!IsDisposed)
            {
                m_toggleText = null;
                base.Dispose();
            }
        }
    }
}