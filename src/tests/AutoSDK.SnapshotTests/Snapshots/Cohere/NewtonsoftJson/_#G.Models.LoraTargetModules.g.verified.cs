//HintName: G.Models.LoraTargetModules.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The possible combinations of LoRA modules to target.<br/>
    ///  - LORA_TARGET_MODULES_UNSPECIFIED: Unspecified LoRA target modules.<br/>
    ///  - LORA_TARGET_MODULES_QV: LoRA adapts the query and value matrices in transformer attention layers.<br/>
    ///  - LORA_TARGET_MODULES_QKVO: LoRA adapts query, key, value, and output matrices in attention layers.<br/>
    ///  - LORA_TARGET_MODULES_QKVO_FFN: LoRA adapts attention projection matrices and feed-forward networks (FFN).<br/>
    /// Default Value: LORA_TARGET_MODULES_UNSPECIFIED
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LoraTargetModules
    {
        /// <summary>
        /// Unspecified LoRA target modules.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LORA_TARGET_MODULES_UNSPECIFIED")]
        UNSPECIFIED,
        /// <summary>
        /// LoRA adapts the query and value matrices in transformer attention layers.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LORA_TARGET_MODULES_QV")]
        QV,
        /// <summary>
        /// LoRA adapts query, key, value, and output matrices in attention layers.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LORA_TARGET_MODULES_QKVO")]
        QKVO,
        /// <summary>
        /// LoRA adapts attention projection matrices and feed-forward networks (FFN).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LORA_TARGET_MODULES_QKVO_FFN")]
        QKVOFFN,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LoraTargetModulesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LoraTargetModules value)
        {
            return value switch
            {
                LoraTargetModules.UNSPECIFIED => "LORA_TARGET_MODULES_UNSPECIFIED",
                LoraTargetModules.QV => "LORA_TARGET_MODULES_QV",
                LoraTargetModules.QKVO => "LORA_TARGET_MODULES_QKVO",
                LoraTargetModules.QKVOFFN => "LORA_TARGET_MODULES_QKVO_FFN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LoraTargetModules? ToEnum(string value)
        {
            return value switch
            {
                "LORA_TARGET_MODULES_UNSPECIFIED" => LoraTargetModules.UNSPECIFIED,
                "LORA_TARGET_MODULES_QV" => LoraTargetModules.QV,
                "LORA_TARGET_MODULES_QKVO" => LoraTargetModules.QKVO,
                "LORA_TARGET_MODULES_QKVO_FFN" => LoraTargetModules.QKVOFFN,
                _ => null,
            };
        }
    }
}