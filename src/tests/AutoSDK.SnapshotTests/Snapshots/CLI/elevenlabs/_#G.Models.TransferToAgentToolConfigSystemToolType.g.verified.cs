﻿//HintName: G.Models.TransferToAgentToolConfigSystemToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: transfer_to_agent
    /// </summary>
    public enum TransferToAgentToolConfigSystemToolType
    {
        /// <summary>
        /// 
        /// </summary>
        TransferToAgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferToAgentToolConfigSystemToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferToAgentToolConfigSystemToolType value)
        {
            return value switch
            {
                TransferToAgentToolConfigSystemToolType.TransferToAgent => "transfer_to_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferToAgentToolConfigSystemToolType? ToEnum(string value)
        {
            return value switch
            {
                "transfer_to_agent" => TransferToAgentToolConfigSystemToolType.TransferToAgent,
                _ => null,
            };
        }
    }
}