//HintName: G.Models.WorkflowCredentialDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WorkflowCredentialDiscriminatorProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic")]
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic-bedrock")]
        AnthropicBedrock,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anyscale")]
        Anyscale,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assembly-ai")]
        AssemblyAi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="azure")]
        Azure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="azure-openai")]
        AzureOpenai,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="byo-sip-trunk")]
        ByoSipTrunk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cartesia")]
        Cartesia,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cerebras")]
        Cerebras,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cloudflare")]
        Cloudflare,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom-credential")]
        CustomCredential,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom-llm")]
        CustomLlm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deep-seek")]
        DeepSeek,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deepgram")]
        Deepgram,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deepinfra")]
        Deepinfra,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="elevenlabs")]
        Elevenlabs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="email")]
        Email,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gcp")]
        Gcp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ghl.oauth2-authorization")]
        GhlOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gladia")]
        Gladia,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gohighlevel")]
        Gohighlevel,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google")]
        Google,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google.calendar.oauth2-authorization")]
        GoogleCalendarOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google.calendar.oauth2-client")]
        GoogleCalendarOauth2Client,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google.sheets.oauth2-authorization")]
        GoogleSheetsOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="groq")]
        Groq,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hume")]
        Hume,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inflection-ai")]
        InflectionAi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inworld")]
        Inworld,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="langfuse")]
        Langfuse,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lmnt")]
        Lmnt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="make")]
        Make,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="minimax")]
        Minimax,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mistral")]
        Mistral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neuphonic")]
        Neuphonic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai")]
        Openai,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openrouter")]
        Openrouter,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="perplexity-ai")]
        PerplexityAi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="playht")]
        Playht,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rime-ai")]
        RimeAi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="runpod")]
        Runpod,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="s3")]
        S3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slack-webhook")]
        SlackWebhook,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slack.oauth2-authorization")]
        SlackOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="smallest-ai")]
        SmallestAi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="soniox")]
        Soniox,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="speechmatics")]
        Speechmatics,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="supabase")]
        Supabase,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tavus")]
        Tavus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="together-ai")]
        TogetherAi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trieve")]
        Trieve,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="twilio")]
        Twilio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vonage")]
        Vonage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webhook")]
        Webhook,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wellsaid")]
        Wellsaid,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="xai")]
        Xai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowCredentialDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowCredentialDiscriminatorProvider value)
        {
            return value switch
            {
                WorkflowCredentialDiscriminatorProvider.Anthropic => "anthropic",
                WorkflowCredentialDiscriminatorProvider.AnthropicBedrock => "anthropic-bedrock",
                WorkflowCredentialDiscriminatorProvider.Anyscale => "anyscale",
                WorkflowCredentialDiscriminatorProvider.AssemblyAi => "assembly-ai",
                WorkflowCredentialDiscriminatorProvider.Azure => "azure",
                WorkflowCredentialDiscriminatorProvider.AzureOpenai => "azure-openai",
                WorkflowCredentialDiscriminatorProvider.ByoSipTrunk => "byo-sip-trunk",
                WorkflowCredentialDiscriminatorProvider.Cartesia => "cartesia",
                WorkflowCredentialDiscriminatorProvider.Cerebras => "cerebras",
                WorkflowCredentialDiscriminatorProvider.Cloudflare => "cloudflare",
                WorkflowCredentialDiscriminatorProvider.CustomCredential => "custom-credential",
                WorkflowCredentialDiscriminatorProvider.CustomLlm => "custom-llm",
                WorkflowCredentialDiscriminatorProvider.DeepSeek => "deep-seek",
                WorkflowCredentialDiscriminatorProvider.Deepgram => "deepgram",
                WorkflowCredentialDiscriminatorProvider.Deepinfra => "deepinfra",
                WorkflowCredentialDiscriminatorProvider.Elevenlabs => "elevenlabs",
                WorkflowCredentialDiscriminatorProvider.Email => "email",
                WorkflowCredentialDiscriminatorProvider.Gcp => "gcp",
                WorkflowCredentialDiscriminatorProvider.GhlOauth2Authorization => "ghl.oauth2-authorization",
                WorkflowCredentialDiscriminatorProvider.Gladia => "gladia",
                WorkflowCredentialDiscriminatorProvider.Gohighlevel => "gohighlevel",
                WorkflowCredentialDiscriminatorProvider.Google => "google",
                WorkflowCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization => "google.calendar.oauth2-authorization",
                WorkflowCredentialDiscriminatorProvider.GoogleCalendarOauth2Client => "google.calendar.oauth2-client",
                WorkflowCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization => "google.sheets.oauth2-authorization",
                WorkflowCredentialDiscriminatorProvider.Groq => "groq",
                WorkflowCredentialDiscriminatorProvider.Hume => "hume",
                WorkflowCredentialDiscriminatorProvider.InflectionAi => "inflection-ai",
                WorkflowCredentialDiscriminatorProvider.Inworld => "inworld",
                WorkflowCredentialDiscriminatorProvider.Langfuse => "langfuse",
                WorkflowCredentialDiscriminatorProvider.Lmnt => "lmnt",
                WorkflowCredentialDiscriminatorProvider.Make => "make",
                WorkflowCredentialDiscriminatorProvider.Minimax => "minimax",
                WorkflowCredentialDiscriminatorProvider.Mistral => "mistral",
                WorkflowCredentialDiscriminatorProvider.Neuphonic => "neuphonic",
                WorkflowCredentialDiscriminatorProvider.Openai => "openai",
                WorkflowCredentialDiscriminatorProvider.Openrouter => "openrouter",
                WorkflowCredentialDiscriminatorProvider.PerplexityAi => "perplexity-ai",
                WorkflowCredentialDiscriminatorProvider.Playht => "playht",
                WorkflowCredentialDiscriminatorProvider.RimeAi => "rime-ai",
                WorkflowCredentialDiscriminatorProvider.Runpod => "runpod",
                WorkflowCredentialDiscriminatorProvider.S3 => "s3",
                WorkflowCredentialDiscriminatorProvider.SlackWebhook => "slack-webhook",
                WorkflowCredentialDiscriminatorProvider.SlackOauth2Authorization => "slack.oauth2-authorization",
                WorkflowCredentialDiscriminatorProvider.SmallestAi => "smallest-ai",
                WorkflowCredentialDiscriminatorProvider.Soniox => "soniox",
                WorkflowCredentialDiscriminatorProvider.Speechmatics => "speechmatics",
                WorkflowCredentialDiscriminatorProvider.Supabase => "supabase",
                WorkflowCredentialDiscriminatorProvider.Tavus => "tavus",
                WorkflowCredentialDiscriminatorProvider.TogetherAi => "together-ai",
                WorkflowCredentialDiscriminatorProvider.Trieve => "trieve",
                WorkflowCredentialDiscriminatorProvider.Twilio => "twilio",
                WorkflowCredentialDiscriminatorProvider.Vonage => "vonage",
                WorkflowCredentialDiscriminatorProvider.Webhook => "webhook",
                WorkflowCredentialDiscriminatorProvider.Wellsaid => "wellsaid",
                WorkflowCredentialDiscriminatorProvider.Xai => "xai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowCredentialDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => WorkflowCredentialDiscriminatorProvider.Anthropic,
                "anthropic-bedrock" => WorkflowCredentialDiscriminatorProvider.AnthropicBedrock,
                "anyscale" => WorkflowCredentialDiscriminatorProvider.Anyscale,
                "assembly-ai" => WorkflowCredentialDiscriminatorProvider.AssemblyAi,
                "azure" => WorkflowCredentialDiscriminatorProvider.Azure,
                "azure-openai" => WorkflowCredentialDiscriminatorProvider.AzureOpenai,
                "byo-sip-trunk" => WorkflowCredentialDiscriminatorProvider.ByoSipTrunk,
                "cartesia" => WorkflowCredentialDiscriminatorProvider.Cartesia,
                "cerebras" => WorkflowCredentialDiscriminatorProvider.Cerebras,
                "cloudflare" => WorkflowCredentialDiscriminatorProvider.Cloudflare,
                "custom-credential" => WorkflowCredentialDiscriminatorProvider.CustomCredential,
                "custom-llm" => WorkflowCredentialDiscriminatorProvider.CustomLlm,
                "deep-seek" => WorkflowCredentialDiscriminatorProvider.DeepSeek,
                "deepgram" => WorkflowCredentialDiscriminatorProvider.Deepgram,
                "deepinfra" => WorkflowCredentialDiscriminatorProvider.Deepinfra,
                "elevenlabs" => WorkflowCredentialDiscriminatorProvider.Elevenlabs,
                "email" => WorkflowCredentialDiscriminatorProvider.Email,
                "gcp" => WorkflowCredentialDiscriminatorProvider.Gcp,
                "ghl.oauth2-authorization" => WorkflowCredentialDiscriminatorProvider.GhlOauth2Authorization,
                "gladia" => WorkflowCredentialDiscriminatorProvider.Gladia,
                "gohighlevel" => WorkflowCredentialDiscriminatorProvider.Gohighlevel,
                "google" => WorkflowCredentialDiscriminatorProvider.Google,
                "google.calendar.oauth2-authorization" => WorkflowCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization,
                "google.calendar.oauth2-client" => WorkflowCredentialDiscriminatorProvider.GoogleCalendarOauth2Client,
                "google.sheets.oauth2-authorization" => WorkflowCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization,
                "groq" => WorkflowCredentialDiscriminatorProvider.Groq,
                "hume" => WorkflowCredentialDiscriminatorProvider.Hume,
                "inflection-ai" => WorkflowCredentialDiscriminatorProvider.InflectionAi,
                "inworld" => WorkflowCredentialDiscriminatorProvider.Inworld,
                "langfuse" => WorkflowCredentialDiscriminatorProvider.Langfuse,
                "lmnt" => WorkflowCredentialDiscriminatorProvider.Lmnt,
                "make" => WorkflowCredentialDiscriminatorProvider.Make,
                "minimax" => WorkflowCredentialDiscriminatorProvider.Minimax,
                "mistral" => WorkflowCredentialDiscriminatorProvider.Mistral,
                "neuphonic" => WorkflowCredentialDiscriminatorProvider.Neuphonic,
                "openai" => WorkflowCredentialDiscriminatorProvider.Openai,
                "openrouter" => WorkflowCredentialDiscriminatorProvider.Openrouter,
                "perplexity-ai" => WorkflowCredentialDiscriminatorProvider.PerplexityAi,
                "playht" => WorkflowCredentialDiscriminatorProvider.Playht,
                "rime-ai" => WorkflowCredentialDiscriminatorProvider.RimeAi,
                "runpod" => WorkflowCredentialDiscriminatorProvider.Runpod,
                "s3" => WorkflowCredentialDiscriminatorProvider.S3,
                "slack-webhook" => WorkflowCredentialDiscriminatorProvider.SlackWebhook,
                "slack.oauth2-authorization" => WorkflowCredentialDiscriminatorProvider.SlackOauth2Authorization,
                "smallest-ai" => WorkflowCredentialDiscriminatorProvider.SmallestAi,
                "soniox" => WorkflowCredentialDiscriminatorProvider.Soniox,
                "speechmatics" => WorkflowCredentialDiscriminatorProvider.Speechmatics,
                "supabase" => WorkflowCredentialDiscriminatorProvider.Supabase,
                "tavus" => WorkflowCredentialDiscriminatorProvider.Tavus,
                "together-ai" => WorkflowCredentialDiscriminatorProvider.TogetherAi,
                "trieve" => WorkflowCredentialDiscriminatorProvider.Trieve,
                "twilio" => WorkflowCredentialDiscriminatorProvider.Twilio,
                "vonage" => WorkflowCredentialDiscriminatorProvider.Vonage,
                "webhook" => WorkflowCredentialDiscriminatorProvider.Webhook,
                "wellsaid" => WorkflowCredentialDiscriminatorProvider.Wellsaid,
                "xai" => WorkflowCredentialDiscriminatorProvider.Xai,
                _ => null,
            };
        }
    }
}