//HintName: G.Models.CreatePromptRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreatePromptRequest : global::System.IEquatable<CreatePromptRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateChatPromptRequest? CreateChatPromptRequest { get; init; }
#else
        public global::G.CreateChatPromptRequest? CreateChatPromptRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateChatPromptRequest))]
#endif
        public bool IsCreateChatPromptRequest => CreateChatPromptRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateTextPromptRequest? CreateTextPromptRequest { get; init; }
#else
        public global::G.CreateTextPromptRequest? CreateTextPromptRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateTextPromptRequest))]
#endif
        public bool IsCreateTextPromptRequest => CreateTextPromptRequest != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreatePromptRequest(global::G.CreateChatPromptRequest value) => new CreatePromptRequest((global::G.CreateChatPromptRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateChatPromptRequest?(CreatePromptRequest @this) => @this.CreateChatPromptRequest;

        /// <summary>
        /// 
        /// </summary>
        public CreatePromptRequest(global::G.CreateChatPromptRequest? value)
        {
            CreateChatPromptRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreatePromptRequest(global::G.CreateTextPromptRequest value) => new CreatePromptRequest((global::G.CreateTextPromptRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateTextPromptRequest?(CreatePromptRequest @this) => @this.CreateTextPromptRequest;

        /// <summary>
        /// 
        /// </summary>
        public CreatePromptRequest(global::G.CreateTextPromptRequest? value)
        {
            CreateTextPromptRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreatePromptRequest(
            global::G.CreateChatPromptRequest? createChatPromptRequest,
            global::G.CreateTextPromptRequest? createTextPromptRequest
            )
        {
            CreateChatPromptRequest = createChatPromptRequest;
            CreateTextPromptRequest = createTextPromptRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateTextPromptRequest as object ??
            CreateChatPromptRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CreateChatPromptRequest?.ToString() ??
            CreateTextPromptRequest?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreateChatPromptRequest && !IsCreateTextPromptRequest || !IsCreateChatPromptRequest && IsCreateTextPromptRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateChatPromptRequest?, TResult>? createChatPromptRequest = null,
            global::System.Func<global::G.CreateTextPromptRequest?, TResult>? createTextPromptRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateChatPromptRequest && createChatPromptRequest != null)
            {
                return createChatPromptRequest(CreateChatPromptRequest!);
            }
            else if (IsCreateTextPromptRequest && createTextPromptRequest != null)
            {
                return createTextPromptRequest(CreateTextPromptRequest!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateChatPromptRequest?>? createChatPromptRequest = null,
            global::System.Action<global::G.CreateTextPromptRequest?>? createTextPromptRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateChatPromptRequest)
            {
                createChatPromptRequest?.Invoke(CreateChatPromptRequest!);
            }
            else if (IsCreateTextPromptRequest)
            {
                createTextPromptRequest?.Invoke(CreateTextPromptRequest!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateChatPromptRequest,
                typeof(global::G.CreateChatPromptRequest),
                CreateTextPromptRequest,
                typeof(global::G.CreateTextPromptRequest),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(CreatePromptRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateChatPromptRequest?>.Default.Equals(CreateChatPromptRequest, other.CreateChatPromptRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateTextPromptRequest?>.Default.Equals(CreateTextPromptRequest, other.CreateTextPromptRequest) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreatePromptRequest obj1, CreatePromptRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreatePromptRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreatePromptRequest obj1, CreatePromptRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreatePromptRequest o && Equals(o);
        }
    }
}
