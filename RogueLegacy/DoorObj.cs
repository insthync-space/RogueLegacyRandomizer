// Rogue Legacy Randomizer - DoorObj.cs
// Last Modified 2022-10-24
// 
// This project is based on the modified disassembly of Rogue Legacy's engine, with permission to do so by its
// original creators. Therefore, the former creators' copyright notice applies to the original disassembly.
// 
// Original Source © 2011-2015, Cellar Door Games Inc.
// Rogue Legacy™ is a trademark or registered trademark of Cellar Door Games Inc. All Rights Reserved.

using System;
using System.Globalization;
using System.Xml;
using DS2DEngine;
using Microsoft.Xna.Framework;
using RogueLegacy.Enums;

namespace RogueLegacy
{
    public class DoorObj : TerrainObj
    {
        private readonly DoorState _mDoorStateType = DoorState.Open;
        public bool Attached;
        public string DoorPosition = "NONE";
        public bool IsBossDoor;
        public bool Locked;
        private SpriteObj m_arrowIcon;

        public DoorObj(RoomObj roomRef, int width, int height, DoorState doorStateType) : base(width, height)
        {
            _mDoorStateType = doorStateType;
            Room = roomRef;
            CollisionTypeTag = 0;
            DisableHitboxUpdating = true;
            m_arrowIcon = new SpriteObj("UpArrowSquare_Sprite");
            m_arrowIcon.OutlineWidth = 2;
            m_arrowIcon.Visible = false;
        }

        public RoomObj Room { get; set; }

        public DoorState DoorStateType
        {
            get { return _mDoorStateType; }
        }

        public override void Draw(Camera2D camera)
        {
            if (m_arrowIcon.Visible)
            {
                m_arrowIcon.Position = new Vector2(Bounds.Center.X,
                    Bounds.Top - 10 + (float) Math.Sin(Game.TotalGameTimeSeconds * 20f) * 3f);
                m_arrowIcon.Draw(camera);
                m_arrowIcon.Visible = false;
            }
        }

        public override void CollisionResponse(CollisionBox thisBox, CollisionBox otherBox, int collisionResponseType)
        {
            var playerObj = otherBox.AbsParent as PlayerObj;
            if (!Locked && playerObj != null && playerObj.IsTouchingGround && DoorPosition == "None")
            {
                m_arrowIcon.Visible = true;
            }

            base.CollisionResponse(thisBox, otherBox, collisionResponseType);
        }

        protected override GameObj CreateCloneInstance()
        {
            return new DoorObj(Room, _width, _height, _mDoorStateType);
        }

        protected override void FillCloneInstance(object obj)
        {
            base.FillCloneInstance(obj);
            var doorObj = obj as DoorObj;
            doorObj.Attached = Attached;
            doorObj.IsBossDoor = IsBossDoor;
            doorObj.Locked = Locked;
            doorObj.DoorPosition = DoorPosition;
        }

        public override void Dispose()
        {
            if (!IsDisposed)
            {
                Room = null;
                m_arrowIcon.Dispose();
                m_arrowIcon = null;
                base.Dispose();
            }
        }

        public override void PopulateFromXMLReader(XmlReader reader, CultureInfo ci)
        {
            base.PopulateFromXMLReader(reader, ci);
            if (reader.MoveToAttribute("BossDoor"))
            {
                IsBossDoor = bool.Parse(reader.Value);
            }

            if (reader.MoveToAttribute("DoorPos"))
            {
                DoorPosition = reader.Value;
            }
        }
    }
}
