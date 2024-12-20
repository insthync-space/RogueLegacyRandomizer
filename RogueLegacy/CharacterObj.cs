//  RogueLegacyRandomizer - CharacterObj.cs
//  Last Modified 2023-10-26 12:01 PM
// 
//  This project is based on the modified disassembly of Rogue Legacy's engine, with permission to do so by its
//  original creators. Therefore, the former creators' copyright notice applies to the original disassembly.
// 
//  Original Source - © 2011-2018, Cellar Door Games Inc.
//  Rogue Legacy™ is a trademark or registered trademark of Cellar Door Games Inc. All Rights Reserved.

using DS2DEngine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RogueLegacy.Screens;

namespace RogueLegacy
{
    public abstract class CharacterObj : PhysicsObjContainer, IStateObj, IKillableObj
    {
        protected float CurrentAirSpeed;
        public SpriteEffects InternalFlip;
        private Color m_blinkColour = Color.White;
        protected float m_blinkTimer;
        private int m_currentHealth;
        protected float m_internalAnimationDelay = 0.1f;
        protected bool m_internalIsWeighted = true;
        protected bool m_internalLockFlip;
        protected float m_internalRotation;
        protected Vector2 _internalScale = new Vector2(1f, 1f);
        protected bool m_isKilled;
        protected bool m_isTouchingGround;
        protected ProceduralLevelScreen _levelScreen;
        public float SlopeClimbRotation = 45f;
        protected int StepUp;

        public CharacterObj(string spriteName, PhysicsManager physicsManager, ProceduralLevelScreen levelToAttachTo)
            : base(spriteName, physicsManager)
        {
            _levelScreen = levelToAttachTo;
            CanBeKnockedBack = true;
        }

        public float JumpHeight { get; set; }
        public virtual int MaxHealth { get; internal set; }
        public Vector2 KnockBack { get; internal set; }
        public float DoubleJumpHeight { get; internal set; }
        public bool CanBeKnockedBack { get; set; }

        public int CurrentHealth
        {
            get { return m_currentHealth; }
            set
            {
                m_currentHealth = value;
                if (m_currentHealth > MaxHealth)
                {
                    m_currentHealth = MaxHealth;
                }

                if (m_currentHealth < 0)
                {
                    m_currentHealth = 0;
                }
            }
        }

        public bool IsTouchingGround
        {
            get { return m_isTouchingGround; }
        }

        public Vector2 InternalScale
        {
            get { return _internalScale; }
        }

        public bool IsKilled
        {
            get { return m_isKilled; }
        }

        public int State { get; set; }
        protected abstract void InitializeEV();
        protected abstract void InitializeLogic();

        public virtual void HandleInput() { }

        public virtual void Update(GameTime gameTime)
        {
            if (m_blinkTimer > 0f)
            {
                m_blinkTimer -= (float) gameTime.ElapsedGameTime.TotalSeconds;
                TextureColor = m_blinkColour;
                return;
            }

            if (TextureColor == m_blinkColour)
            {
                TextureColor = Color.White;
            }
        }

        public void Blink(Color blinkColour, float duration)
        {
            m_blinkColour = blinkColour;
            m_blinkTimer = duration;
        }

        public virtual void Kill(bool giveXP = true)
        {
            AccelerationX = 0f;
            AccelerationY = 0f;
            Opacity = 1f;
            CurrentSpeed = 0f;
            StopAnimation();
            Visible = false;
            m_isKilled = true;
            IsCollidable = false;
            IsWeighted = false;
            m_blinkTimer = 0f;
        }

        public virtual void Reset()
        {
            AccelerationX = 0f;
            AccelerationY = 0f;
            CurrentSpeed = 0f;
            CurrentHealth = MaxHealth;
            Opacity = 1f;
            IsCollidable = true;
            IsWeighted = m_internalIsWeighted;
            LockFlip = m_internalLockFlip;
            Rotation = m_internalRotation;
            AnimationDelay = m_internalAnimationDelay;
            Scale = _internalScale;
            Flip = InternalFlip;
            m_isKilled = false;
            Visible = true;
            IsTriggered = false;
        }

        public override void Dispose()
        {
            if (!IsDisposed)
            {
                _levelScreen = null;
                base.Dispose();
            }
        }
    }
}
