//HintName: G.Models.CreateTaskRequestVariant3Mode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTaskRequestVariant3Mode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LEFT")]
        Left,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RIGHT")]
        Right,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTaskRequestVariant3ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTaskRequestVariant3Mode value)
        {
            return value switch
            {
                CreateTaskRequestVariant3Mode.Left => "LEFT",
                CreateTaskRequestVariant3Mode.Right => "RIGHT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTaskRequestVariant3Mode? ToEnum(string value)
        {
            return value switch
            {
                "LEFT" => CreateTaskRequestVariant3Mode.Left,
                "RIGHT" => CreateTaskRequestVariant3Mode.Right,
                _ => null,
            };
        }
    }
}