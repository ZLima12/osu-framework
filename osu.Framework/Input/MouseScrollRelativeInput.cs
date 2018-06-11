﻿// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using OpenTK;

namespace osu.Framework.Input
{
    public class MouseScrollRelativeInput : IInput
    {
        public Vector2 Delta;
        public bool IsPrecise;
        public void Apply(InputState state, IInputStateChangeHandler handler)
        {
            if (Delta != Vector2.Zero)
            {
                state.Mouse.Scroll += Delta;
                state.Mouse.HasPreciseScroll = IsPrecise;
                handler.HandleMouseScrollChange(state);
            }
        }
    }
}
