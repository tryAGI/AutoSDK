using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    private static string GetPromptTemplateHelperClassName(
        CSharpSettings settings)
    {
        var configuredClassName = settings.PromptTemplateHelperClassName;
        if (string.IsNullOrWhiteSpace(configuredClassName))
        {
            configuredClassName = "PromptTemplateManager";
        }

        return configuredClassName
            .ToPropertyName()
            .UseWordSeparator('.', '-', '_', '/');
    }

    public static string GeneratePromptTemplateHelpers(
        CSharpSettings settings,
        string className,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return $@"#nullable enable

namespace {settings.Namespace}
{{
    /// <summary>
    /// Identifies a prompt version lookup.
    /// </summary>
    public sealed class PromptTemplateRequest
    {{
        public PromptTemplateRequest(
            string id,
            string? version = null,
            string? environment = null)
        {{
            if (string.IsNullOrWhiteSpace(id))
            {{
                throw new global::System.ArgumentException(""Prompt id must be non-empty."", nameof(id));
            }}

            Id = id;
            Version = version;
            Environment = environment;
        }}

        public string Id {{ get; }}

        public string? Version {{ get; }}

        public string? Environment {{ get; }}

        internal string CacheKey => Id + ""\n"" + (Version ?? string.Empty) + ""\n"" + (Environment ?? string.Empty);
    }}

    /// <summary>
    /// A chat prompt message with renderable content.
    /// </summary>
    public sealed class PromptTemplateMessage
    {{
        public PromptTemplateMessage(
            string role,
            string content)
        {{
            if (string.IsNullOrWhiteSpace(role))
            {{
                throw new global::System.ArgumentException(""Prompt message role must be non-empty."", nameof(role));
            }}
            if (content is null)
            {{
                throw new global::System.ArgumentNullException(nameof(content));
            }}

            Role = role;
            Content = content;
        }}

        public string Role {{ get; }}

        public string Content {{ get; }}

        public PromptTemplateMessage WithContent(
            string content)
        {{
            return new PromptTemplateMessage(Role, content);
        }}
    }}

    /// <summary>
    /// A resolved prompt template with optional string body, chat messages, variables, metadata, and model config.
    /// </summary>
    public sealed class PromptTemplate
    {{
        public PromptTemplate(
            string id,
            string? version = null,
            string? environment = null,
            string? body = null,
            global::System.Collections.Generic.IEnumerable<PromptTemplateMessage>? messages = null,
            global::System.Collections.Generic.IReadOnlyDictionary<string, string>? variables = null,
            global::System.Collections.Generic.IReadOnlyDictionary<string, string>? metadata = null,
            global::System.Collections.Generic.IReadOnlyDictionary<string, string>? modelConfig = null)
        {{
            if (string.IsNullOrWhiteSpace(id))
            {{
                throw new global::System.ArgumentException(""Prompt id must be non-empty."", nameof(id));
            }}

            Id = id;
            Version = version;
            Environment = environment;
            Body = body;
            Messages = CopyMessages(messages);
            Variables = CopyDictionary(variables);
            Metadata = CopyDictionary(metadata);
            ModelConfig = CopyDictionary(modelConfig);
        }}

        public string Id {{ get; }}

        public string? Version {{ get; }}

        public string? Environment {{ get; }}

        public string? Body {{ get; }}

        public global::System.Collections.Generic.IReadOnlyList<PromptTemplateMessage> Messages {{ get; }}

        public global::System.Collections.Generic.IReadOnlyDictionary<string, string> Variables {{ get; }}

        public global::System.Collections.Generic.IReadOnlyDictionary<string, string> Metadata {{ get; }}

        public global::System.Collections.Generic.IReadOnlyDictionary<string, string> ModelConfig {{ get; }}

        private static global::System.Collections.Generic.IReadOnlyList<PromptTemplateMessage> CopyMessages(
            global::System.Collections.Generic.IEnumerable<PromptTemplateMessage>? messages)
        {{
            if (messages is null)
            {{
                return global::System.Array.Empty<PromptTemplateMessage>();
            }}

            var result = new global::System.Collections.Generic.List<PromptTemplateMessage>();
            foreach (var message in messages)
            {{
                if (message is null)
                {{
                    throw new global::System.ArgumentException(""Prompt messages must not contain null values."", nameof(messages));
                }}

                result.Add(message);
            }}

            return result;
        }}

        private static global::System.Collections.Generic.IReadOnlyDictionary<string, string> CopyDictionary(
            global::System.Collections.Generic.IReadOnlyDictionary<string, string>? values)
        {{
            if (values is null)
            {{
                return new global::System.Collections.Generic.Dictionary<string, string>(
                    global::System.StringComparer.Ordinal);
            }}

            return new global::System.Collections.Generic.Dictionary<string, string>(
                values,
                global::System.StringComparer.Ordinal);
        }}
    }}

    /// <summary>
    /// Exception thrown when prompt template rendering cannot resolve all variables or partials.
    /// </summary>
    public sealed class PromptTemplateRenderException : global::System.Exception
    {{
        public PromptTemplateRenderException(
            global::System.Collections.Generic.IEnumerable<string> missingVariables)
            : base(""Prompt template is missing values for: "" + string.Join("", "", missingVariables))
        {{
            MissingVariables = new global::System.Collections.Generic.List<string>(missingVariables);
        }}

        public global::System.Collections.Generic.IReadOnlyList<string> MissingVariables {{ get; }}
    }}

    /// <summary>
    /// Resolves, caches, and renders string or chat prompt templates.
    /// </summary>
    public sealed class {className}
    {{
        private const int MaxPartialDepth = 16;
        private readonly global::System.Func<PromptTemplateRequest, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<PromptTemplate>> _resolver;
        private readonly global::System.Collections.Generic.Dictionary<string, CacheEntry> _cache =
            new global::System.Collections.Generic.Dictionary<string, CacheEntry>(global::System.StringComparer.Ordinal);
        private readonly object _cacheGate = new object();
        private global::System.Func<global::System.DateTimeOffset> _clock = static () => global::System.DateTimeOffset.UtcNow;

        public {className}(
            global::System.Func<PromptTemplateRequest, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<PromptTemplate>> resolver,
            global::System.TimeSpan? cacheTtl = null)
        {{
            _resolver = resolver ?? throw new global::System.ArgumentNullException(nameof(resolver));
            CacheTtl = cacheTtl ?? global::System.TimeSpan.FromMinutes(5);
            if (CacheTtl <= global::System.TimeSpan.Zero)
            {{
                throw new global::System.ArgumentOutOfRangeException(nameof(cacheTtl), ""Prompt template cache TTL must be positive."");
            }}
        }}

        public global::System.TimeSpan CacheTtl {{ get; }}

        public global::System.Func<global::System.DateTimeOffset> Clock
        {{
            get => _clock;
            set => _clock = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }}

        public global::System.Threading.Tasks.Task<PromptTemplate> GetPromptVersionAsync(
            string id,
            string version,
            string? environment = null,
            bool refresh = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            if (string.IsNullOrWhiteSpace(version))
            {{
                throw new global::System.ArgumentException(""Prompt version must be non-empty."", nameof(version));
            }}

            return GetPromptAsync(id, version, environment, refresh, cancellationToken);
        }}

        public global::System.Threading.Tasks.Task<PromptTemplate> GetPromptAsync(
            string id,
            string? version = null,
            string? environment = null,
            bool refresh = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            return GetPromptAsync(
                new PromptTemplateRequest(id, version, environment),
                refresh,
                cancellationToken);
        }}

        public async global::System.Threading.Tasks.Task<PromptTemplate> GetPromptAsync(
            PromptTemplateRequest request,
            bool refresh = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            if (request is null)
            {{
                throw new global::System.ArgumentNullException(nameof(request));
            }}

            if (!refresh && TryGetCached(request.CacheKey, out var cachedPrompt))
            {{
                return cachedPrompt;
            }}

            var resolvedPrompt = await _resolver(request, cancellationToken).ConfigureAwait(false);
            if (resolvedPrompt is null)
            {{
                throw new global::System.InvalidOperationException(""Prompt template resolver returned null."");
            }}

            StoreCached(request.CacheKey, resolvedPrompt);
            return resolvedPrompt;
        }}

        public async global::System.Threading.Tasks.Task<string> RenderStringAsync(
            string id,
            global::System.Collections.Generic.IReadOnlyDictionary<string, string> variables,
            string? version = null,
            string? environment = null,
            global::System.Collections.Generic.IReadOnlyDictionary<string, string>? partials = null,
            bool refresh = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            var prompt = await GetPromptAsync(id, version, environment, refresh, cancellationToken).ConfigureAwait(false);
            if (prompt.Body is null)
            {{
                throw new global::System.InvalidOperationException(""Resolved prompt does not contain a string body."");
            }}

            return Render(prompt.Body, variables, partials);
        }}

        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IReadOnlyList<PromptTemplateMessage>> RenderMessagesAsync(
            string id,
            global::System.Collections.Generic.IReadOnlyDictionary<string, string> variables,
            string? version = null,
            string? environment = null,
            global::System.Collections.Generic.IReadOnlyDictionary<string, string>? partials = null,
            bool refresh = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            var prompt = await GetPromptAsync(id, version, environment, refresh, cancellationToken).ConfigureAwait(false);
            if (prompt.Messages.Count == 0)
            {{
                throw new global::System.InvalidOperationException(""Resolved prompt does not contain chat messages."");
            }}

            return RenderMessages(prompt.Messages, variables, partials);
        }}

        public void ClearCache()
        {{
            lock (_cacheGate)
            {{
                _cache.Clear();
            }}
        }}

        public bool RemoveFromCache(
            string id,
            string? version = null,
            string? environment = null)
        {{
            var request = new PromptTemplateRequest(id, version, environment);
            lock (_cacheGate)
            {{
                return _cache.Remove(request.CacheKey);
            }}
        }}

        public static string Render(
            string template,
            global::System.Collections.Generic.IReadOnlyDictionary<string, string> variables,
            global::System.Collections.Generic.IReadOnlyDictionary<string, string>? partials = null)
        {{
            if (template is null)
            {{
                throw new global::System.ArgumentNullException(nameof(template));
            }}
            if (variables is null)
            {{
                throw new global::System.ArgumentNullException(nameof(variables));
            }}

            var missingVariables = new global::System.Collections.Generic.HashSet<string>(
                global::System.StringComparer.Ordinal);
            var rendered = RenderTemplate(
                template,
                variables,
                partials,
                missingVariables,
                depth: 0);

            if (missingVariables.Count > 0)
            {{
                throw new PromptTemplateRenderException(missingVariables);
            }}

            return rendered;
        }}

        public static global::System.Collections.Generic.IReadOnlyList<PromptTemplateMessage> RenderMessages(
            global::System.Collections.Generic.IEnumerable<PromptTemplateMessage> messages,
            global::System.Collections.Generic.IReadOnlyDictionary<string, string> variables,
            global::System.Collections.Generic.IReadOnlyDictionary<string, string>? partials = null)
        {{
            if (messages is null)
            {{
                throw new global::System.ArgumentNullException(nameof(messages));
            }}

            var renderedMessages = new global::System.Collections.Generic.List<PromptTemplateMessage>();
            foreach (var message in messages)
            {{
                if (message is null)
                {{
                    throw new global::System.ArgumentException(""Prompt messages must not contain null values."", nameof(messages));
                }}

                renderedMessages.Add(message.WithContent(Render(message.Content, variables, partials)));
            }}

            return renderedMessages;
        }}

        private bool TryGetCached(
            string cacheKey,
            out PromptTemplate prompt)
        {{
            lock (_cacheGate)
            {{
                if (_cache.TryGetValue(cacheKey, out var entry) &&
                    entry.ExpiresAt > Clock())
                {{
                    prompt = entry.Prompt;
                    return true;
                }}

                _cache.Remove(cacheKey);
            }}

            prompt = null!;
            return false;
        }}

        private void StoreCached(
            string cacheKey,
            PromptTemplate prompt)
        {{
            lock (_cacheGate)
            {{
                _cache[cacheKey] = new CacheEntry(prompt, Clock() + CacheTtl);
            }}
        }}

        private static string RenderTemplate(
            string template,
            global::System.Collections.Generic.IReadOnlyDictionary<string, string> variables,
            global::System.Collections.Generic.IReadOnlyDictionary<string, string>? partials,
            global::System.Collections.Generic.HashSet<string> missingVariables,
            int depth)
        {{
            if (depth > MaxPartialDepth)
            {{
                throw new global::System.InvalidOperationException(""Prompt template partial nesting exceeded the maximum depth."");
            }}

            var builder = new global::System.Text.StringBuilder();
            var index = 0;
            while (index < template.Length)
            {{
                var open = template.IndexOf(""{{{{"", index, global::System.StringComparison.Ordinal);
                if (open < 0)
                {{
                    builder.Append(template, index, template.Length - index);
                    break;
                }}

                builder.Append(template, index, open - index);
                var close = template.IndexOf(""}}}}"", open + 2, global::System.StringComparison.Ordinal);
                if (close < 0)
                {{
                    builder.Append(template, open, template.Length - open);
                    break;
                }}

                var token = template.Substring(open + 2, close - open - 2).Trim();
                if (token.Length == 0)
                {{
                    builder.Append(template, open, close + 2 - open);
                }}
                else if (token[0] == '>')
                {{
                    var partialName = token.Substring(1).Trim();
                    if (partialName.Length == 0)
                    {{
                        builder.Append(template, open, close + 2 - open);
                    }}
                    else if (partials is not null && partials.TryGetValue(partialName, out var partialTemplate))
                    {{
                        builder.Append(RenderTemplate(
                            partialTemplate,
                            variables,
                            partials,
                            missingVariables,
                            depth + 1));
                    }}
                    else
                    {{
                        missingVariables.Add("">"" + partialName);
                    }}
                }}
                else if (variables.TryGetValue(token, out var value))
                {{
                    builder.Append(value);
                }}
                else
                {{
                    missingVariables.Add(token);
                }}

                index = close + 2;
            }}

            return builder.ToString();
        }}

        private sealed class CacheEntry
        {{
            public CacheEntry(
                PromptTemplate prompt,
                global::System.DateTimeOffset expiresAt)
            {{
                Prompt = prompt;
                ExpiresAt = expiresAt;
            }}

            public PromptTemplate Prompt {{ get; }}

            public global::System.DateTimeOffset ExpiresAt {{ get; }}
        }}
    }}
}}
";
    }
}
