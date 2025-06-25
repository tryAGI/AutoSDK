//HintName: G.Models.SystemToolConfigOutputParamsDiscriminatorSystemToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SystemToolConfigOutputParamsDiscriminatorSystemToolType
    {
        /// <summary>
        /// 
        /// </summary>
        EndCall,
        /// <summary>
        /// 
        /// </summary>
        LanguageDetection,
        /// <summary>
        /// 
        /// </summary>
        SkipTurn,
        /// <summary>
        /// 
        /// </summary>
        TransferToAgent,
        /// <summary>
        /// 
        /// </summary>
        TransferToNumber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SystemToolConfigOutputParamsDiscriminatorSystemToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SystemToolConfigOutputParamsDiscriminatorSystemToolType value)
        {
            return value switch
            {
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.EndCall => "end_call",
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.LanguageDetection => "language_detection",
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.SkipTurn => "skip_turn",
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.TransferToAgent => "transfer_to_agent",
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.TransferToNumber => "transfer_to_number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SystemToolConfigOutputParamsDiscriminatorSystemToolType? ToEnum(string value)
        {
            return value switch
            {
                "end_call" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.EndCall,
                "language_detection" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.LanguageDetection,
                "skip_turn" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.SkipTurn,
                "transfer_to_agent" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.TransferToAgent,
                "transfer_to_number" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.TransferToNumber,
                _ => null,
            };
        }
    }
}