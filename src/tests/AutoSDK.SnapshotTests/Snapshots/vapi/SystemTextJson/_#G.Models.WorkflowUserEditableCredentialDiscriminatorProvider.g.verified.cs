//HintName: G.Models.WorkflowUserEditableCredentialDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowUserEditableCredentialDiscriminatorProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        AnthropicBedrock,
        /// <summary>
        /// 
        /// </summary>
        Anyscale,
        /// <summary>
        /// 
        /// </summary>
        AssemblyAi,
        /// <summary>
        /// 
        /// </summary>
        Azure,
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
        /// <summary>
        /// 
        /// </summary>
        ByoSipTrunk,
        /// <summary>
        /// 
        /// </summary>
        Cartesia,
        /// <summary>
        /// 
        /// </summary>
        Cerebras,
        /// <summary>
        /// 
        /// </summary>
        Cloudflare,
        /// <summary>
        /// 
        /// </summary>
        CustomCredential,
        /// <summary>
        /// 
        /// </summary>
        CustomLlm,
        /// <summary>
        /// 
        /// </summary>
        DeepSeek,
        /// <summary>
        /// 
        /// </summary>
        Deepgram,
        /// <summary>
        /// 
        /// </summary>
        Deepinfra,
        /// <summary>
        /// 
        /// </summary>
        Elevenlabs,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        Gcp,
        /// <summary>
        /// 
        /// </summary>
        GhlOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        Gladia,
        /// <summary>
        /// 
        /// </summary>
        Gohighlevel,
        /// <summary>
        /// 
        /// </summary>
        Google,
        /// <summary>
        /// 
        /// </summary>
        GoogleCalendarOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        GoogleCalendarOauth2Client,
        /// <summary>
        /// 
        /// </summary>
        GoogleSheetsOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        Groq,
        /// <summary>
        /// 
        /// </summary>
        Hume,
        /// <summary>
        /// 
        /// </summary>
        InflectionAi,
        /// <summary>
        /// 
        /// </summary>
        Inworld,
        /// <summary>
        /// 
        /// </summary>
        Langfuse,
        /// <summary>
        /// 
        /// </summary>
        Lmnt,
        /// <summary>
        /// 
        /// </summary>
        Make,
        /// <summary>
        /// 
        /// </summary>
        Minimax,
        /// <summary>
        /// 
        /// </summary>
        Mistral,
        /// <summary>
        /// 
        /// </summary>
        Neuphonic,
        /// <summary>
        /// 
        /// </summary>
        Openai,
        /// <summary>
        /// 
        /// </summary>
        Openrouter,
        /// <summary>
        /// 
        /// </summary>
        PerplexityAi,
        /// <summary>
        /// 
        /// </summary>
        Playht,
        /// <summary>
        /// 
        /// </summary>
        RimeAi,
        /// <summary>
        /// 
        /// </summary>
        Runpod,
        /// <summary>
        /// 
        /// </summary>
        S3,
        /// <summary>
        /// 
        /// </summary>
        SlackWebhook,
        /// <summary>
        /// 
        /// </summary>
        SlackOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        SmallestAi,
        /// <summary>
        /// 
        /// </summary>
        Soniox,
        /// <summary>
        /// 
        /// </summary>
        Speechmatics,
        /// <summary>
        /// 
        /// </summary>
        Supabase,
        /// <summary>
        /// 
        /// </summary>
        Tavus,
        /// <summary>
        /// 
        /// </summary>
        TogetherAi,
        /// <summary>
        /// 
        /// </summary>
        Trieve,
        /// <summary>
        /// 
        /// </summary>
        Twilio,
        /// <summary>
        /// 
        /// </summary>
        Vonage,
        /// <summary>
        /// 
        /// </summary>
        Webhook,
        /// <summary>
        /// 
        /// </summary>
        Wellsaid,
        /// <summary>
        /// 
        /// </summary>
        Xai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowUserEditableCredentialDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowUserEditableCredentialDiscriminatorProvider value)
        {
            return value switch
            {
                WorkflowUserEditableCredentialDiscriminatorProvider.Anthropic => "anthropic",
                WorkflowUserEditableCredentialDiscriminatorProvider.AnthropicBedrock => "anthropic-bedrock",
                WorkflowUserEditableCredentialDiscriminatorProvider.Anyscale => "anyscale",
                WorkflowUserEditableCredentialDiscriminatorProvider.AssemblyAi => "assembly-ai",
                WorkflowUserEditableCredentialDiscriminatorProvider.Azure => "azure",
                WorkflowUserEditableCredentialDiscriminatorProvider.AzureOpenai => "azure-openai",
                WorkflowUserEditableCredentialDiscriminatorProvider.ByoSipTrunk => "byo-sip-trunk",
                WorkflowUserEditableCredentialDiscriminatorProvider.Cartesia => "cartesia",
                WorkflowUserEditableCredentialDiscriminatorProvider.Cerebras => "cerebras",
                WorkflowUserEditableCredentialDiscriminatorProvider.Cloudflare => "cloudflare",
                WorkflowUserEditableCredentialDiscriminatorProvider.CustomCredential => "custom-credential",
                WorkflowUserEditableCredentialDiscriminatorProvider.CustomLlm => "custom-llm",
                WorkflowUserEditableCredentialDiscriminatorProvider.DeepSeek => "deep-seek",
                WorkflowUserEditableCredentialDiscriminatorProvider.Deepgram => "deepgram",
                WorkflowUserEditableCredentialDiscriminatorProvider.Deepinfra => "deepinfra",
                WorkflowUserEditableCredentialDiscriminatorProvider.Elevenlabs => "elevenlabs",
                WorkflowUserEditableCredentialDiscriminatorProvider.Email => "email",
                WorkflowUserEditableCredentialDiscriminatorProvider.Gcp => "gcp",
                WorkflowUserEditableCredentialDiscriminatorProvider.GhlOauth2Authorization => "ghl.oauth2-authorization",
                WorkflowUserEditableCredentialDiscriminatorProvider.Gladia => "gladia",
                WorkflowUserEditableCredentialDiscriminatorProvider.Gohighlevel => "gohighlevel",
                WorkflowUserEditableCredentialDiscriminatorProvider.Google => "google",
                WorkflowUserEditableCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization => "google.calendar.oauth2-authorization",
                WorkflowUserEditableCredentialDiscriminatorProvider.GoogleCalendarOauth2Client => "google.calendar.oauth2-client",
                WorkflowUserEditableCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization => "google.sheets.oauth2-authorization",
                WorkflowUserEditableCredentialDiscriminatorProvider.Groq => "groq",
                WorkflowUserEditableCredentialDiscriminatorProvider.Hume => "hume",
                WorkflowUserEditableCredentialDiscriminatorProvider.InflectionAi => "inflection-ai",
                WorkflowUserEditableCredentialDiscriminatorProvider.Inworld => "inworld",
                WorkflowUserEditableCredentialDiscriminatorProvider.Langfuse => "langfuse",
                WorkflowUserEditableCredentialDiscriminatorProvider.Lmnt => "lmnt",
                WorkflowUserEditableCredentialDiscriminatorProvider.Make => "make",
                WorkflowUserEditableCredentialDiscriminatorProvider.Minimax => "minimax",
                WorkflowUserEditableCredentialDiscriminatorProvider.Mistral => "mistral",
                WorkflowUserEditableCredentialDiscriminatorProvider.Neuphonic => "neuphonic",
                WorkflowUserEditableCredentialDiscriminatorProvider.Openai => "openai",
                WorkflowUserEditableCredentialDiscriminatorProvider.Openrouter => "openrouter",
                WorkflowUserEditableCredentialDiscriminatorProvider.PerplexityAi => "perplexity-ai",
                WorkflowUserEditableCredentialDiscriminatorProvider.Playht => "playht",
                WorkflowUserEditableCredentialDiscriminatorProvider.RimeAi => "rime-ai",
                WorkflowUserEditableCredentialDiscriminatorProvider.Runpod => "runpod",
                WorkflowUserEditableCredentialDiscriminatorProvider.S3 => "s3",
                WorkflowUserEditableCredentialDiscriminatorProvider.SlackWebhook => "slack-webhook",
                WorkflowUserEditableCredentialDiscriminatorProvider.SlackOauth2Authorization => "slack.oauth2-authorization",
                WorkflowUserEditableCredentialDiscriminatorProvider.SmallestAi => "smallest-ai",
                WorkflowUserEditableCredentialDiscriminatorProvider.Soniox => "soniox",
                WorkflowUserEditableCredentialDiscriminatorProvider.Speechmatics => "speechmatics",
                WorkflowUserEditableCredentialDiscriminatorProvider.Supabase => "supabase",
                WorkflowUserEditableCredentialDiscriminatorProvider.Tavus => "tavus",
                WorkflowUserEditableCredentialDiscriminatorProvider.TogetherAi => "together-ai",
                WorkflowUserEditableCredentialDiscriminatorProvider.Trieve => "trieve",
                WorkflowUserEditableCredentialDiscriminatorProvider.Twilio => "twilio",
                WorkflowUserEditableCredentialDiscriminatorProvider.Vonage => "vonage",
                WorkflowUserEditableCredentialDiscriminatorProvider.Webhook => "webhook",
                WorkflowUserEditableCredentialDiscriminatorProvider.Wellsaid => "wellsaid",
                WorkflowUserEditableCredentialDiscriminatorProvider.Xai => "xai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowUserEditableCredentialDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => WorkflowUserEditableCredentialDiscriminatorProvider.Anthropic,
                "anthropic-bedrock" => WorkflowUserEditableCredentialDiscriminatorProvider.AnthropicBedrock,
                "anyscale" => WorkflowUserEditableCredentialDiscriminatorProvider.Anyscale,
                "assembly-ai" => WorkflowUserEditableCredentialDiscriminatorProvider.AssemblyAi,
                "azure" => WorkflowUserEditableCredentialDiscriminatorProvider.Azure,
                "azure-openai" => WorkflowUserEditableCredentialDiscriminatorProvider.AzureOpenai,
                "byo-sip-trunk" => WorkflowUserEditableCredentialDiscriminatorProvider.ByoSipTrunk,
                "cartesia" => WorkflowUserEditableCredentialDiscriminatorProvider.Cartesia,
                "cerebras" => WorkflowUserEditableCredentialDiscriminatorProvider.Cerebras,
                "cloudflare" => WorkflowUserEditableCredentialDiscriminatorProvider.Cloudflare,
                "custom-credential" => WorkflowUserEditableCredentialDiscriminatorProvider.CustomCredential,
                "custom-llm" => WorkflowUserEditableCredentialDiscriminatorProvider.CustomLlm,
                "deep-seek" => WorkflowUserEditableCredentialDiscriminatorProvider.DeepSeek,
                "deepgram" => WorkflowUserEditableCredentialDiscriminatorProvider.Deepgram,
                "deepinfra" => WorkflowUserEditableCredentialDiscriminatorProvider.Deepinfra,
                "elevenlabs" => WorkflowUserEditableCredentialDiscriminatorProvider.Elevenlabs,
                "email" => WorkflowUserEditableCredentialDiscriminatorProvider.Email,
                "gcp" => WorkflowUserEditableCredentialDiscriminatorProvider.Gcp,
                "ghl.oauth2-authorization" => WorkflowUserEditableCredentialDiscriminatorProvider.GhlOauth2Authorization,
                "gladia" => WorkflowUserEditableCredentialDiscriminatorProvider.Gladia,
                "gohighlevel" => WorkflowUserEditableCredentialDiscriminatorProvider.Gohighlevel,
                "google" => WorkflowUserEditableCredentialDiscriminatorProvider.Google,
                "google.calendar.oauth2-authorization" => WorkflowUserEditableCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization,
                "google.calendar.oauth2-client" => WorkflowUserEditableCredentialDiscriminatorProvider.GoogleCalendarOauth2Client,
                "google.sheets.oauth2-authorization" => WorkflowUserEditableCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization,
                "groq" => WorkflowUserEditableCredentialDiscriminatorProvider.Groq,
                "hume" => WorkflowUserEditableCredentialDiscriminatorProvider.Hume,
                "inflection-ai" => WorkflowUserEditableCredentialDiscriminatorProvider.InflectionAi,
                "inworld" => WorkflowUserEditableCredentialDiscriminatorProvider.Inworld,
                "langfuse" => WorkflowUserEditableCredentialDiscriminatorProvider.Langfuse,
                "lmnt" => WorkflowUserEditableCredentialDiscriminatorProvider.Lmnt,
                "make" => WorkflowUserEditableCredentialDiscriminatorProvider.Make,
                "minimax" => WorkflowUserEditableCredentialDiscriminatorProvider.Minimax,
                "mistral" => WorkflowUserEditableCredentialDiscriminatorProvider.Mistral,
                "neuphonic" => WorkflowUserEditableCredentialDiscriminatorProvider.Neuphonic,
                "openai" => WorkflowUserEditableCredentialDiscriminatorProvider.Openai,
                "openrouter" => WorkflowUserEditableCredentialDiscriminatorProvider.Openrouter,
                "perplexity-ai" => WorkflowUserEditableCredentialDiscriminatorProvider.PerplexityAi,
                "playht" => WorkflowUserEditableCredentialDiscriminatorProvider.Playht,
                "rime-ai" => WorkflowUserEditableCredentialDiscriminatorProvider.RimeAi,
                "runpod" => WorkflowUserEditableCredentialDiscriminatorProvider.Runpod,
                "s3" => WorkflowUserEditableCredentialDiscriminatorProvider.S3,
                "slack-webhook" => WorkflowUserEditableCredentialDiscriminatorProvider.SlackWebhook,
                "slack.oauth2-authorization" => WorkflowUserEditableCredentialDiscriminatorProvider.SlackOauth2Authorization,
                "smallest-ai" => WorkflowUserEditableCredentialDiscriminatorProvider.SmallestAi,
                "soniox" => WorkflowUserEditableCredentialDiscriminatorProvider.Soniox,
                "speechmatics" => WorkflowUserEditableCredentialDiscriminatorProvider.Speechmatics,
                "supabase" => WorkflowUserEditableCredentialDiscriminatorProvider.Supabase,
                "tavus" => WorkflowUserEditableCredentialDiscriminatorProvider.Tavus,
                "together-ai" => WorkflowUserEditableCredentialDiscriminatorProvider.TogetherAi,
                "trieve" => WorkflowUserEditableCredentialDiscriminatorProvider.Trieve,
                "twilio" => WorkflowUserEditableCredentialDiscriminatorProvider.Twilio,
                "vonage" => WorkflowUserEditableCredentialDiscriminatorProvider.Vonage,
                "webhook" => WorkflowUserEditableCredentialDiscriminatorProvider.Webhook,
                "wellsaid" => WorkflowUserEditableCredentialDiscriminatorProvider.Wellsaid,
                "xai" => WorkflowUserEditableCredentialDiscriminatorProvider.Xai,
                _ => null,
            };
        }
    }
}