//HintName: G.Models.CreateTextToImageRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateTextToImageRequest : global::System.IEquatable<CreateTextToImageRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateTextToImageRequestGen4ImageTurbo? Gen4ImageTurbo { get; init; }
#else
        public global::G.CreateTextToImageRequestGen4ImageTurbo? Gen4ImageTurbo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gen4ImageTurbo))]
#endif
        public bool IsGen4ImageTurbo => Gen4ImageTurbo != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateTextToImageRequestGen4Image? Gen4Image { get; init; }
#else
        public global::G.CreateTextToImageRequestGen4Image? Gen4Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gen4Image))]
#endif
        public bool IsGen4Image => Gen4Image != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateTextToImageRequestGemini25Flash? Gemini25Flash { get; init; }
#else
        public global::G.CreateTextToImageRequestGemini25Flash? Gemini25Flash { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gemini25Flash))]
#endif
        public bool IsGemini25Flash => Gemini25Flash != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateTextToImageRequest(global::G.CreateTextToImageRequestGen4ImageTurbo value) => new CreateTextToImageRequest((global::G.CreateTextToImageRequestGen4ImageTurbo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateTextToImageRequestGen4ImageTurbo?(CreateTextToImageRequest @this) => @this.Gen4ImageTurbo;

        /// <summary>
        /// 
        /// </summary>
        public CreateTextToImageRequest(global::G.CreateTextToImageRequestGen4ImageTurbo? value)
        {
            Gen4ImageTurbo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateTextToImageRequest(global::G.CreateTextToImageRequestGen4Image value) => new CreateTextToImageRequest((global::G.CreateTextToImageRequestGen4Image?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateTextToImageRequestGen4Image?(CreateTextToImageRequest @this) => @this.Gen4Image;

        /// <summary>
        /// 
        /// </summary>
        public CreateTextToImageRequest(global::G.CreateTextToImageRequestGen4Image? value)
        {
            Gen4Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateTextToImageRequest(global::G.CreateTextToImageRequestGemini25Flash value) => new CreateTextToImageRequest((global::G.CreateTextToImageRequestGemini25Flash?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateTextToImageRequestGemini25Flash?(CreateTextToImageRequest @this) => @this.Gemini25Flash;

        /// <summary>
        /// 
        /// </summary>
        public CreateTextToImageRequest(global::G.CreateTextToImageRequestGemini25Flash? value)
        {
            Gemini25Flash = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateTextToImageRequest(
            global::G.CreateTextToImageRequestGen4ImageTurbo? gen4ImageTurbo,
            global::G.CreateTextToImageRequestGen4Image? gen4Image,
            global::G.CreateTextToImageRequestGemini25Flash? gemini25Flash
            )
        {
            Gen4ImageTurbo = gen4ImageTurbo;
            Gen4Image = gen4Image;
            Gemini25Flash = gemini25Flash;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Gemini25Flash as object ??
            Gen4Image as object ??
            Gen4ImageTurbo as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Gen4ImageTurbo?.ToString() ??
            Gen4Image?.ToString() ??
            Gemini25Flash?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGen4ImageTurbo && !IsGen4Image && !IsGemini25Flash || !IsGen4ImageTurbo && IsGen4Image && !IsGemini25Flash || !IsGen4ImageTurbo && !IsGen4Image && IsGemini25Flash;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateTextToImageRequestGen4ImageTurbo?, TResult>? gen4ImageTurbo = null,
            global::System.Func<global::G.CreateTextToImageRequestGen4Image?, TResult>? gen4Image = null,
            global::System.Func<global::G.CreateTextToImageRequestGemini25Flash?, TResult>? gemini25Flash = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGen4ImageTurbo && gen4ImageTurbo != null)
            {
                return gen4ImageTurbo(Gen4ImageTurbo!);
            }
            else if (IsGen4Image && gen4Image != null)
            {
                return gen4Image(Gen4Image!);
            }
            else if (IsGemini25Flash && gemini25Flash != null)
            {
                return gemini25Flash(Gemini25Flash!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateTextToImageRequestGen4ImageTurbo?>? gen4ImageTurbo = null,
            global::System.Action<global::G.CreateTextToImageRequestGen4Image?>? gen4Image = null,
            global::System.Action<global::G.CreateTextToImageRequestGemini25Flash?>? gemini25Flash = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGen4ImageTurbo)
            {
                gen4ImageTurbo?.Invoke(Gen4ImageTurbo!);
            }
            else if (IsGen4Image)
            {
                gen4Image?.Invoke(Gen4Image!);
            }
            else if (IsGemini25Flash)
            {
                gemini25Flash?.Invoke(Gemini25Flash!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Gen4ImageTurbo,
                typeof(global::G.CreateTextToImageRequestGen4ImageTurbo),
                Gen4Image,
                typeof(global::G.CreateTextToImageRequestGen4Image),
                Gemini25Flash,
                typeof(global::G.CreateTextToImageRequestGemini25Flash),
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
        public bool Equals(CreateTextToImageRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateTextToImageRequestGen4ImageTurbo?>.Default.Equals(Gen4ImageTurbo, other.Gen4ImageTurbo) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateTextToImageRequestGen4Image?>.Default.Equals(Gen4Image, other.Gen4Image) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateTextToImageRequestGemini25Flash?>.Default.Equals(Gemini25Flash, other.Gemini25Flash) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateTextToImageRequest obj1, CreateTextToImageRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateTextToImageRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateTextToImageRequest obj1, CreateTextToImageRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateTextToImageRequest o && Equals(o);
        }
    }
}
