//HintName: G.Models.FunctionNodeVariant2ToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tool type for function nodes
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FunctionNodeVariant2ToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="local")]
        Local,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shared")]
        Shared,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionNodeVariant2ToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionNodeVariant2ToolType value)
        {
            return value switch
            {
                FunctionNodeVariant2ToolType.Local => "local",
                FunctionNodeVariant2ToolType.Shared => "shared",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionNodeVariant2ToolType? ToEnum(string value)
        {
            return value switch
            {
                "local" => FunctionNodeVariant2ToolType.Local,
                "shared" => FunctionNodeVariant2ToolType.Shared,
                _ => null,
            };
        }
    }
}