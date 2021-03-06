﻿using System.Drawing;
using BrazilianLux.Misc;
using EloBuddy;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;

namespace BrazilianLux.Bases
{
    public enum Colors
    {
        Red = 0,
        Pink = 1,
        Purple = 2,
        DeepPurple = 3,
        Indigo = 4,
        Blue = 5,
        LightBlue = 6,
        Cyan = 7,
        Teal = 8,
        Green = 9,
        LightGreen = 10,
        Lime = 11,
        Yellow = 12,
        Amber = 13,
        Orange = 14,
        DeepOrange = 15,
        Brown = 16,
        Gray = 17,
        BlueGray = 18,
        White = 19,
        Black = 20
    }

    public class ColorSlider
    {
        public Color CurrentColor { get; private set; }

        public CheckBox BaseCheckBox { get; }
        public Slider BaseSlider { get; }

        public bool BoolValue => BaseCheckBox.CurrentValue;

        private readonly SpellSlot Slot;
        private readonly string Name;

        public ColorSlider(Menu menu,SpellSlot slot)
        {
            Slot = slot;

            BaseCheckBox = new CheckBox("Draw " + Slot + " : ", false);

            BaseSlider = new Slider(Slot + " Color: ", Utils.GetRandomNumber(0, 20), 0, 20)
            {
                CurrentValue = Utils.GetRandomNumber(0, 20)
            };

            var c = GetColor(BaseSlider.CurrentValue);
            BaseSlider.DisplayName = Slot == SpellSlot.Unknown ? Name + " Color: " + c : Slot + " Color: " + c;

            BaseSlider.OnValueChange += BaseSlider_OnValueChange;

            menu.Add("booldraw" + slot, BaseCheckBox);
            menu.Add("colordraw" + slot, BaseSlider);
        }

        public ColorSlider(Menu menu, string name)
        {
            Name = name;
            Slot = SpellSlot.Unknown;

            BaseCheckBox = new CheckBox("Draw " + name, false);

            BaseSlider = new Slider(name + " Color: ", Utils.GetRandomNumber(0, 20), 0, 20)
            {
                CurrentValue = Utils.GetRandomNumber(0, 20)
            };

            var c = GetColor(BaseSlider.CurrentValue);
            BaseSlider.DisplayName = Slot == SpellSlot.Unknown ? Name + " Color: " + c : Slot + " Color: " + c;

            BaseSlider.OnValueChange += BaseSlider_OnValueChange;

            menu.Add("booldraw" + name, BaseCheckBox);
            menu.Add("colordraw" + name, BaseSlider);
        }

        private void BaseSlider_OnValueChange(ValueBase<int> sender, ValueBase<int>.ValueChangeArgs args)
        {
            var c = GetColor(BaseSlider.CurrentValue);
            BaseSlider.DisplayName = Slot == SpellSlot.Unknown ? Name + " Color: " + c : Slot + " Color: " + c;
            CurrentColor = GetColor(c);
        }

        public Color GetColor()
        {
            switch (BaseSlider.CurrentValue)
            {
                case 0:
                    return Color.Red;
                case 1:
                    return Color.DeepPink;
                case 2:
                    return Color.MediumPurple;
                case 3:
                    return Color.Purple;
                case 4:
                    return Color.DarkBlue;
                case 5:
                    return Color.Blue;
                case 6:
                    return Color.DeepSkyBlue;
                case 7:
                    return Color.Cyan;
                case 8:
                    return Color.Teal;
                case 9:
                    return Color.Green;
                case 10:
                    return Color.GreenYellow;
                case 11:
                    return Color.Lime;
                case 12:
                    return Color.Yellow;
                case 13:
                    return Color.Orange;
                case 14:
                    return Color.DarkOrange;
                case 15:
                    return Color.OrangeRed;
                case 16:
                    return Color.Brown;
                case 17:
                    return Color.Gray;
                case 18:
                    return Color.LightSlateGray;
                case 19:
                    return Color.White;
                case 20:
                    return Color.Black;
            }
            return Color.AliceBlue;
        }

        private Colors GetColor(int i)
        {
            switch (i)
            {
                case 0:
                    return Colors.Red;
                case 1:
                    return Colors.Pink;
                case 2:
                    return Colors.Purple;
                case 3:
                    return Colors.DeepPurple;
                case 4:
                    return Colors.Indigo;
                case 5:
                    return Colors.Blue;
                case 6:
                    return Colors.LightBlue;
                case 7:
                    return Colors.Cyan;
                case 8:
                    return Colors.Teal;
                case 9:
                    return Colors.Green;
                case 10:
                    return Colors.LightGreen;
                case 11:
                    return Colors.Lime;
                case 12:
                    return Colors.Yellow;
                case 13:
                    return Colors.Amber;
                case 14:
                    return Colors.Orange;
                case 15:
                    return Colors.DeepOrange;
                case 16:
                    return Colors.Brown;
                case 17:
                    return Colors.Gray;
                case 18:
                    return Colors.BlueGray;
                case 19:
                    return Colors.White;
                case 20:
                    return Colors.Black;
            }
            return Colors.White;
        }

        private Color GetColor(Colors color)
        {
            switch ((int)color)
            {
                case 0:
                    return Color.Red;
                case 1:
                    return Color.DeepPink;
                case 2:
                    return Color.MediumPurple;
                case 3:
                    return Color.Purple;
                case 4:
                    return Color.DarkBlue;
                case 5:
                    return Color.Blue;
                case 6:
                    return Color.DeepSkyBlue;
                case 7:
                    return Color.Cyan;
                case 8:
                    return Color.Teal;
                case 9:
                    return Color.Green;
                case 10:
                    return Color.GreenYellow;
                case 11:
                    return Color.Lime;
                case 12:
                    return Color.Yellow;
                case 13:
                    return Color.Orange;
                case 14:
                    return Color.DarkOrange;
                case 15:
                    return Color.OrangeRed;
                case 16:
                    return Color.Brown;
                case 17:
                    return Color.Gray;
                case 18:
                    return Color.LightSlateGray;
                case 19:
                    return Color.White;
                case 20:
                    return Color.Black;
            }
            return Color.AliceBlue;
        }
    }
}
