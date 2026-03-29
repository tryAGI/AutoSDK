//HintName: G.Models.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType
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
    public static class PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType value)
        {
            return value switch
            {
                PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType.Id => "id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType? ToEnum(string value)
        {
            return value switch
            {
                "id" => PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType.Id,
                _ => null,
            };
        }
    }
}