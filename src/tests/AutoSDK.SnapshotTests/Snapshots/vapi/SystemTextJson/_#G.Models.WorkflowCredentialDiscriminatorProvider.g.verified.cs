//HintName: G.Models.WorkflowCredentialDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowCredentialDiscriminatorProvider
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