//HintName: G.Models.UpdateWorkflowDTOCredentialDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateWorkflowDTOCredentialDiscriminatorProvider
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
    public static class UpdateWorkflowDTOCredentialDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateWorkflowDTOCredentialDiscriminatorProvider value)
        {
            return value switch
            {
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Anthropic => "anthropic",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.AnthropicBedrock => "anthropic-bedrock",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Anyscale => "anyscale",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.AssemblyAi => "assembly-ai",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Azure => "azure",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.AzureOpenai => "azure-openai",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.ByoSipTrunk => "byo-sip-trunk",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Cartesia => "cartesia",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Cerebras => "cerebras",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Cloudflare => "cloudflare",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.CustomCredential => "custom-credential",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.CustomLlm => "custom-llm",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.DeepSeek => "deep-seek",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Deepgram => "deepgram",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Deepinfra => "deepinfra",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Elevenlabs => "elevenlabs",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Email => "email",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Gcp => "gcp",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.GhlOauth2Authorization => "ghl.oauth2-authorization",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Gladia => "gladia",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Gohighlevel => "gohighlevel",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Google => "google",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization => "google.calendar.oauth2-authorization",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Client => "google.calendar.oauth2-client",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization => "google.sheets.oauth2-authorization",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Groq => "groq",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Hume => "hume",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.InflectionAi => "inflection-ai",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Inworld => "inworld",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Langfuse => "langfuse",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Lmnt => "lmnt",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Make => "make",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Minimax => "minimax",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Mistral => "mistral",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Neuphonic => "neuphonic",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Openai => "openai",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Openrouter => "openrouter",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.PerplexityAi => "perplexity-ai",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Playht => "playht",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.RimeAi => "rime-ai",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Runpod => "runpod",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.S3 => "s3",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.SlackWebhook => "slack-webhook",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.SlackOauth2Authorization => "slack.oauth2-authorization",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.SmallestAi => "smallest-ai",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Soniox => "soniox",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Speechmatics => "speechmatics",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Supabase => "supabase",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Tavus => "tavus",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.TogetherAi => "together-ai",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Trieve => "trieve",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Twilio => "twilio",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Vonage => "vonage",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Webhook => "webhook",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Wellsaid => "wellsaid",
                UpdateWorkflowDTOCredentialDiscriminatorProvider.Xai => "xai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateWorkflowDTOCredentialDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Anthropic,
                "anthropic-bedrock" => UpdateWorkflowDTOCredentialDiscriminatorProvider.AnthropicBedrock,
                "anyscale" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Anyscale,
                "assembly-ai" => UpdateWorkflowDTOCredentialDiscriminatorProvider.AssemblyAi,
                "azure" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Azure,
                "azure-openai" => UpdateWorkflowDTOCredentialDiscriminatorProvider.AzureOpenai,
                "byo-sip-trunk" => UpdateWorkflowDTOCredentialDiscriminatorProvider.ByoSipTrunk,
                "cartesia" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Cartesia,
                "cerebras" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Cerebras,
                "cloudflare" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Cloudflare,
                "custom-credential" => UpdateWorkflowDTOCredentialDiscriminatorProvider.CustomCredential,
                "custom-llm" => UpdateWorkflowDTOCredentialDiscriminatorProvider.CustomLlm,
                "deep-seek" => UpdateWorkflowDTOCredentialDiscriminatorProvider.DeepSeek,
                "deepgram" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Deepgram,
                "deepinfra" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Deepinfra,
                "elevenlabs" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Elevenlabs,
                "email" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Email,
                "gcp" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Gcp,
                "ghl.oauth2-authorization" => UpdateWorkflowDTOCredentialDiscriminatorProvider.GhlOauth2Authorization,
                "gladia" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Gladia,
                "gohighlevel" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Gohighlevel,
                "google" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Google,
                "google.calendar.oauth2-authorization" => UpdateWorkflowDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization,
                "google.calendar.oauth2-client" => UpdateWorkflowDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Client,
                "google.sheets.oauth2-authorization" => UpdateWorkflowDTOCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization,
                "groq" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Groq,
                "hume" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Hume,
                "inflection-ai" => UpdateWorkflowDTOCredentialDiscriminatorProvider.InflectionAi,
                "inworld" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Inworld,
                "langfuse" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Langfuse,
                "lmnt" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Lmnt,
                "make" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Make,
                "minimax" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Minimax,
                "mistral" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Mistral,
                "neuphonic" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Neuphonic,
                "openai" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Openai,
                "openrouter" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Openrouter,
                "perplexity-ai" => UpdateWorkflowDTOCredentialDiscriminatorProvider.PerplexityAi,
                "playht" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Playht,
                "rime-ai" => UpdateWorkflowDTOCredentialDiscriminatorProvider.RimeAi,
                "runpod" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Runpod,
                "s3" => UpdateWorkflowDTOCredentialDiscriminatorProvider.S3,
                "slack-webhook" => UpdateWorkflowDTOCredentialDiscriminatorProvider.SlackWebhook,
                "slack.oauth2-authorization" => UpdateWorkflowDTOCredentialDiscriminatorProvider.SlackOauth2Authorization,
                "smallest-ai" => UpdateWorkflowDTOCredentialDiscriminatorProvider.SmallestAi,
                "soniox" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Soniox,
                "speechmatics" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Speechmatics,
                "supabase" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Supabase,
                "tavus" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Tavus,
                "together-ai" => UpdateWorkflowDTOCredentialDiscriminatorProvider.TogetherAi,
                "trieve" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Trieve,
                "twilio" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Twilio,
                "vonage" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Vonage,
                "webhook" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Webhook,
                "wellsaid" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Wellsaid,
                "xai" => UpdateWorkflowDTOCredentialDiscriminatorProvider.Xai,
                _ => null,
            };
        }
    }
}