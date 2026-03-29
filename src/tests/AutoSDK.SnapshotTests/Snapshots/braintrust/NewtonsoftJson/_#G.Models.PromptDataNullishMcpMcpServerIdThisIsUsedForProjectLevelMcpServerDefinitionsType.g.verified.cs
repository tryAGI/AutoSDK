//HintName: G.Models.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="id")]
        Id,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType value)
        {
            return value switch
            {
                PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType.Id => "id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType? ToEnum(string value)
        {
            return value switch
            {
                "id" => PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType.Id,
                _ => null,
            };
        }
    }
}