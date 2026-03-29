//HintName: G.Models.MakeToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "make" for Make tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MakeToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="make")]
        Make,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MakeToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MakeToolType value)
        {
            return value switch
            {
                MakeToolType.Make => "make",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MakeToolType? ToEnum(string value)
        {
            return value switch
            {
                "make" => MakeToolType.Make,
                _ => null,
            };
        }
    }
}