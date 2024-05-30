//HintName: G.Models.UpdateUserChatColorColor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateUserChatColorColor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="blue")]
        Blue,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="blue_violet")]
        BlueViolet,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cadet_blue")]
        CadetBlue,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chocolate")]
        Chocolate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="coral")]
        Coral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dodger_blue")]
        DodgerBlue,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="firebrick")]
        Firebrick,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="golden_rod")]
        GoldenRod,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="green")]
        Green,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hot_pink")]
        HotPink,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="orange_red")]
        OrangeRed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="red")]
        Red,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sea_green")]
        SeaGreen,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spring_green")]
        SpringGreen,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="yellow_green")]
        YellowGreen,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateUserChatColorColorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateUserChatColorColor value)
        {
            return value switch
            {
                UpdateUserChatColorColor.Blue => "blue",
                UpdateUserChatColorColor.BlueViolet => "blue_violet",
                UpdateUserChatColorColor.CadetBlue => "cadet_blue",
                UpdateUserChatColorColor.Chocolate => "chocolate",
                UpdateUserChatColorColor.Coral => "coral",
                UpdateUserChatColorColor.DodgerBlue => "dodger_blue",
                UpdateUserChatColorColor.Firebrick => "firebrick",
                UpdateUserChatColorColor.GoldenRod => "golden_rod",
                UpdateUserChatColorColor.Green => "green",
                UpdateUserChatColorColor.HotPink => "hot_pink",
                UpdateUserChatColorColor.OrangeRed => "orange_red",
                UpdateUserChatColorColor.Red => "red",
                UpdateUserChatColorColor.SeaGreen => "sea_green",
                UpdateUserChatColorColor.SpringGreen => "spring_green",
                UpdateUserChatColorColor.YellowGreen => "yellow_green",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateUserChatColorColor ToEnum(string value)
        {
            return value switch
            {
                "blue" => UpdateUserChatColorColor.Blue,
                "blue_violet" => UpdateUserChatColorColor.BlueViolet,
                "cadet_blue" => UpdateUserChatColorColor.CadetBlue,
                "chocolate" => UpdateUserChatColorColor.Chocolate,
                "coral" => UpdateUserChatColorColor.Coral,
                "dodger_blue" => UpdateUserChatColorColor.DodgerBlue,
                "firebrick" => UpdateUserChatColorColor.Firebrick,
                "golden_rod" => UpdateUserChatColorColor.GoldenRod,
                "green" => UpdateUserChatColorColor.Green,
                "hot_pink" => UpdateUserChatColorColor.HotPink,
                "orange_red" => UpdateUserChatColorColor.OrangeRed,
                "red" => UpdateUserChatColorColor.Red,
                "sea_green" => UpdateUserChatColorColor.SeaGreen,
                "spring_green" => UpdateUserChatColorColor.SpringGreen,
                "yellow_green" => UpdateUserChatColorColor.YellowGreen,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}