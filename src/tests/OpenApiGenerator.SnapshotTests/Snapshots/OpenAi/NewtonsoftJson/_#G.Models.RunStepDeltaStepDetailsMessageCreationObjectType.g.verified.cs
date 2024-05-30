//HintName: G.Models.RunStepDeltaStepDetailsMessageCreationObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `message_creation`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStepDeltaStepDetailsMessageCreationObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message_creation")]
        MessageCreation,
    }

    public static class RunStepDeltaStepDetailsMessageCreationObjectTypeExtensions
    {
        public static string ToValueString(this RunStepDeltaStepDetailsMessageCreationObjectType value)
        {
            return value switch
            {
                RunStepDeltaStepDetailsMessageCreationObjectType.MessageCreation => "message_creation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDeltaStepDetailsMessageCreationObjectType ToEnum(string value)
        {
            return value switch
            {
                "message_creation" => RunStepDeltaStepDetailsMessageCreationObjectType.MessageCreation,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDeltaStepDetailsMessageCreationObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => RunStepDeltaStepDetailsMessageCreationObjectType.MessageCreation,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}