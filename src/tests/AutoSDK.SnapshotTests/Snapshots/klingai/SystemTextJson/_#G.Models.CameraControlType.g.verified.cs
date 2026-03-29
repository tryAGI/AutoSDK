//HintName: G.Models.CameraControlType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Camera control type.
    /// </summary>
    public enum CameraControlType
    {
        /// <summary>
        /// 
        /// </summary>
        DownBack,
        /// <summary>
        /// 
        /// </summary>
        ForwardUp,
        /// <summary>
        /// 
        /// </summary>
        LeftTurnForward,
        /// <summary>
        /// 
        /// </summary>
        RightTurnForward,
        /// <summary>
        /// 
        /// </summary>
        Simple,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CameraControlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CameraControlType value)
        {
            return value switch
            {
                CameraControlType.DownBack => "down_back",
                CameraControlType.ForwardUp => "forward_up",
                CameraControlType.LeftTurnForward => "left_turn_forward",
                CameraControlType.RightTurnForward => "right_turn_forward",
                CameraControlType.Simple => "simple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CameraControlType? ToEnum(string value)
        {
            return value switch
            {
                "down_back" => CameraControlType.DownBack,
                "forward_up" => CameraControlType.ForwardUp,
                "left_turn_forward" => CameraControlType.LeftTurnForward,
                "right_turn_forward" => CameraControlType.RightTurnForward,
                "simple" => CameraControlType.Simple,
                _ => null,
            };
        }
    }
}