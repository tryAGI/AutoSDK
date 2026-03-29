//HintName: G.Models.ComputerUseServerToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ComputerUseServerToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="computer_use_preview")]
        ComputerUsePreview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerUseServerToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerUseServerToolType value)
        {
            return value switch
            {
                ComputerUseServerToolType.ComputerUsePreview => "computer_use_preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerUseServerToolType? ToEnum(string value)
        {
            return value switch
            {
                "computer_use_preview" => ComputerUseServerToolType.ComputerUsePreview,
                _ => null,
            };
        }
    }
}