//HintName: G.Models.UsageTimeBucketResultItemDiscriminatorObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UsageTimeBucketResultItemDiscriminatorObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization.usage.completions.result")]
        OrganizationUsageCompletionsResult,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization.usage.embeddings.result")]
        OrganizationUsageEmbeddingsResult,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization.usage.moderations.result")]
        OrganizationUsageModerationsResult,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization.usage.images.result")]
        OrganizationUsageImagesResult,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization.usage.audio_speeches.result")]
        OrganizationUsageAudioSpeechesResult,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization.usage.audio_transcriptions.result")]
        OrganizationUsageAudioTranscriptionsResult,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization.usage.vector_stores.result")]
        OrganizationUsageVectorStoresResult,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization.usage.code_interpreter_sessions.result")]
        OrganizationUsageCodeInterpreterSessionsResult,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization.costs.result")]
        OrganizationCostsResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageTimeBucketResultItemDiscriminatorObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageTimeBucketResultItemDiscriminatorObject value)
        {
            return value switch
            {
                UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageCompletionsResult => "organization.usage.completions.result",
                UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageEmbeddingsResult => "organization.usage.embeddings.result",
                UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageModerationsResult => "organization.usage.moderations.result",
                UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageImagesResult => "organization.usage.images.result",
                UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageAudioSpeechesResult => "organization.usage.audio_speeches.result",
                UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageAudioTranscriptionsResult => "organization.usage.audio_transcriptions.result",
                UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageVectorStoresResult => "organization.usage.vector_stores.result",
                UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageCodeInterpreterSessionsResult => "organization.usage.code_interpreter_sessions.result",
                UsageTimeBucketResultItemDiscriminatorObject.OrganizationCostsResult => "organization.costs.result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageTimeBucketResultItemDiscriminatorObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.usage.completions.result" => UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageCompletionsResult,
                "organization.usage.embeddings.result" => UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageEmbeddingsResult,
                "organization.usage.moderations.result" => UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageModerationsResult,
                "organization.usage.images.result" => UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageImagesResult,
                "organization.usage.audio_speeches.result" => UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageAudioSpeechesResult,
                "organization.usage.audio_transcriptions.result" => UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageAudioTranscriptionsResult,
                "organization.usage.vector_stores.result" => UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageVectorStoresResult,
                "organization.usage.code_interpreter_sessions.result" => UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageCodeInterpreterSessionsResult,
                "organization.costs.result" => UsageTimeBucketResultItemDiscriminatorObject.OrganizationCostsResult,
                _ => null,
            };
        }
    }
}