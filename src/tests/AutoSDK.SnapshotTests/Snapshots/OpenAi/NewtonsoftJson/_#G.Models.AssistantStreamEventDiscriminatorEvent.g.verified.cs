//HintName: G.Models.AssistantStreamEventDiscriminatorEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssistantStreamEventDiscriminatorEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="done")]
        Done,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.created")]
        ThreadCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.created")]
        ThreadRunCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.queued")]
        ThreadRunQueued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.in_progress")]
        ThreadRunInProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.requires_action")]
        ThreadRunRequiresAction,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.completed")]
        ThreadRunCompleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.incomplete")]
        ThreadRunIncomplete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.failed")]
        ThreadRunFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.cancelling")]
        ThreadRunCancelling,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.cancelled")]
        ThreadRunCancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.expired")]
        ThreadRunExpired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.step.created")]
        ThreadRunStepCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.step.in_progress")]
        ThreadRunStepInProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.step.delta")]
        ThreadRunStepDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.step.completed")]
        ThreadRunStepCompleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.step.failed")]
        ThreadRunStepFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.step.cancelled")]
        ThreadRunStepCancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.step.expired")]
        ThreadRunStepExpired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.message.created")]
        ThreadMessageCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.message.in_progress")]
        ThreadMessageInProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.message.delta")]
        ThreadMessageDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.message.completed")]
        ThreadMessageCompleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.message.incomplete")]
        ThreadMessageIncomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantStreamEventDiscriminatorEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantStreamEventDiscriminatorEvent value)
        {
            return value switch
            {
                AssistantStreamEventDiscriminatorEvent.Error => "error",
                AssistantStreamEventDiscriminatorEvent.Done => "done",
                AssistantStreamEventDiscriminatorEvent.ThreadCreated => "thread.created",
                AssistantStreamEventDiscriminatorEvent.ThreadRunCreated => "thread.run.created",
                AssistantStreamEventDiscriminatorEvent.ThreadRunQueued => "thread.run.queued",
                AssistantStreamEventDiscriminatorEvent.ThreadRunInProgress => "thread.run.in_progress",
                AssistantStreamEventDiscriminatorEvent.ThreadRunRequiresAction => "thread.run.requires_action",
                AssistantStreamEventDiscriminatorEvent.ThreadRunCompleted => "thread.run.completed",
                AssistantStreamEventDiscriminatorEvent.ThreadRunIncomplete => "thread.run.incomplete",
                AssistantStreamEventDiscriminatorEvent.ThreadRunFailed => "thread.run.failed",
                AssistantStreamEventDiscriminatorEvent.ThreadRunCancelling => "thread.run.cancelling",
                AssistantStreamEventDiscriminatorEvent.ThreadRunCancelled => "thread.run.cancelled",
                AssistantStreamEventDiscriminatorEvent.ThreadRunExpired => "thread.run.expired",
                AssistantStreamEventDiscriminatorEvent.ThreadRunStepCreated => "thread.run.step.created",
                AssistantStreamEventDiscriminatorEvent.ThreadRunStepInProgress => "thread.run.step.in_progress",
                AssistantStreamEventDiscriminatorEvent.ThreadRunStepDelta => "thread.run.step.delta",
                AssistantStreamEventDiscriminatorEvent.ThreadRunStepCompleted => "thread.run.step.completed",
                AssistantStreamEventDiscriminatorEvent.ThreadRunStepFailed => "thread.run.step.failed",
                AssistantStreamEventDiscriminatorEvent.ThreadRunStepCancelled => "thread.run.step.cancelled",
                AssistantStreamEventDiscriminatorEvent.ThreadRunStepExpired => "thread.run.step.expired",
                AssistantStreamEventDiscriminatorEvent.ThreadMessageCreated => "thread.message.created",
                AssistantStreamEventDiscriminatorEvent.ThreadMessageInProgress => "thread.message.in_progress",
                AssistantStreamEventDiscriminatorEvent.ThreadMessageDelta => "thread.message.delta",
                AssistantStreamEventDiscriminatorEvent.ThreadMessageCompleted => "thread.message.completed",
                AssistantStreamEventDiscriminatorEvent.ThreadMessageIncomplete => "thread.message.incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantStreamEventDiscriminatorEvent? ToEnum(string value)
        {
            return value switch
            {
                "error" => AssistantStreamEventDiscriminatorEvent.Error,
                "done" => AssistantStreamEventDiscriminatorEvent.Done,
                "thread.created" => AssistantStreamEventDiscriminatorEvent.ThreadCreated,
                "thread.run.created" => AssistantStreamEventDiscriminatorEvent.ThreadRunCreated,
                "thread.run.queued" => AssistantStreamEventDiscriminatorEvent.ThreadRunQueued,
                "thread.run.in_progress" => AssistantStreamEventDiscriminatorEvent.ThreadRunInProgress,
                "thread.run.requires_action" => AssistantStreamEventDiscriminatorEvent.ThreadRunRequiresAction,
                "thread.run.completed" => AssistantStreamEventDiscriminatorEvent.ThreadRunCompleted,
                "thread.run.incomplete" => AssistantStreamEventDiscriminatorEvent.ThreadRunIncomplete,
                "thread.run.failed" => AssistantStreamEventDiscriminatorEvent.ThreadRunFailed,
                "thread.run.cancelling" => AssistantStreamEventDiscriminatorEvent.ThreadRunCancelling,
                "thread.run.cancelled" => AssistantStreamEventDiscriminatorEvent.ThreadRunCancelled,
                "thread.run.expired" => AssistantStreamEventDiscriminatorEvent.ThreadRunExpired,
                "thread.run.step.created" => AssistantStreamEventDiscriminatorEvent.ThreadRunStepCreated,
                "thread.run.step.in_progress" => AssistantStreamEventDiscriminatorEvent.ThreadRunStepInProgress,
                "thread.run.step.delta" => AssistantStreamEventDiscriminatorEvent.ThreadRunStepDelta,
                "thread.run.step.completed" => AssistantStreamEventDiscriminatorEvent.ThreadRunStepCompleted,
                "thread.run.step.failed" => AssistantStreamEventDiscriminatorEvent.ThreadRunStepFailed,
                "thread.run.step.cancelled" => AssistantStreamEventDiscriminatorEvent.ThreadRunStepCancelled,
                "thread.run.step.expired" => AssistantStreamEventDiscriminatorEvent.ThreadRunStepExpired,
                "thread.message.created" => AssistantStreamEventDiscriminatorEvent.ThreadMessageCreated,
                "thread.message.in_progress" => AssistantStreamEventDiscriminatorEvent.ThreadMessageInProgress,
                "thread.message.delta" => AssistantStreamEventDiscriminatorEvent.ThreadMessageDelta,
                "thread.message.completed" => AssistantStreamEventDiscriminatorEvent.ThreadMessageCompleted,
                "thread.message.incomplete" => AssistantStreamEventDiscriminatorEvent.ThreadMessageIncomplete,
                _ => null,
            };
        }
    }
}