//HintName: G.Models.RunStepDeltaStepDetailsMessageCreationObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `message_creation`.
    /// </summary>
    public enum RunStepDeltaStepDetailsMessageCreationObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        MessageCreation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStepDeltaStepDetailsMessageCreationObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepDeltaStepDetailsMessageCreationObjectType value)
        {
            return value switch
            {
                RunStepDeltaStepDetailsMessageCreationObjectType.MessageCreation => "message_creation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepDeltaStepDetailsMessageCreationObjectType? ToEnum(string value)
        {
            return value switch
            {
                "message_creation" => RunStepDeltaStepDetailsMessageCreationObjectType.MessageCreation,
                _ => null,
            };
        }
    }
}