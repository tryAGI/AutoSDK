// ReSharper disable RedundantNameQualifier
using System.Linq;

namespace AutoSDK.UnitTests.Helpers
{
    public class PathBuilder
    {
        private readonly global::System.Text.StringBuilder _stringBuilder =
            new global::System.Text.StringBuilder(capacity: 256);
        private bool _firstParameter = true;
        
        public PathBuilder(
            string path,
            global::System.Uri? baseUri = null)
        {
            if (baseUri is not null)
            {
                _stringBuilder.Append(baseUri.AbsoluteUri.TrimEnd('/'));
            }
        
            _stringBuilder.Append(path);
        }
        
        public PathBuilder AddRequiredParameter(
            string name,
            string value)
        {
            if (_firstParameter)
            {
                _stringBuilder.Append('?');
                _firstParameter = false;
            }
            else
            {
                _stringBuilder.Append('&');
            }

            _stringBuilder.Append(global::System.Uri.EscapeDataString(name));
            _stringBuilder.Append('=');
            _stringBuilder.Append(global::System.Uri.EscapeDataString(value));
        
            return this;
        }
        
        public PathBuilder AddRequiredParameter(
            string name,
            global::System.Collections.Generic.IEnumerable<string> value,
            string delimiter = ",",
            bool explode = false)
        {
            if (explode)
            {
                foreach (var item in value)
                {
                    AddRequiredParameter($"{name}", item);
                }

                return this;
            }
            
            AddRequiredParameter(name, string.Join(delimiter, value));
        
            return this;
        }
        
        public PathBuilder AddRequiredParameter<T>(
            string name,
            global::System.Collections.Generic.IEnumerable<T> value,
            global::System.Func<T, string> selector,
            string delimiter = ",",
            bool explode = false)
        {
            AddRequiredParameter(name, value.Select(selector).ToArray(), delimiter, explode);
        
            return this;
        }
        
        public PathBuilder AddOptionalParameter(
            string name,
            string? value)
        {
            if (value is not null)
            {
                AddRequiredParameter(name, value);
            }
        
            return this;
        }
        
        public PathBuilder AddOptionalParameter(
            string name,
            global::System.Collections.Generic.IEnumerable<string>? value,
            string delimiter = ",",
            bool explode = false)
        {
            if (value is not null)
            {
                AddRequiredParameter(name, value, delimiter, explode);
            }
        
            return this;
        }
        
        public PathBuilder AddOptionalParameter<T>(
            string name,
            global::System.Collections.Generic.IEnumerable<T>? value,
            global::System.Func<T, string> selector,
            string delimiter = ",",
            bool explode = false)
        {
            if (value is not null)
            {
                AddRequiredParameter(name, value.Select(selector).ToArray(), delimiter, explode);
            }
        
            return this;
        }
        
        public PathBuilder AddRequiredParameter<T>(
            string name,
            T value,
            string? format = null,
            global::System.IFormatProvider? formatProvider = null)
            where T : global::System.IFormattable
        {
            AddRequiredParameter(name, value.ToString(format, formatProvider));
        
            return this;
        }
        
        public PathBuilder AddOptionalParameter<T>(
            string name,
            T? value,
            string? format = null,
            global::System.IFormatProvider? formatProvider = null)
            where T : global::System.IFormattable
        {
            if (value is not null)
            {
                AddOptionalParameter(name, value.ToString(format, formatProvider));
            }
        
            return this;
        }
        
        public override string ToString() => _stringBuilder.ToString();
    }
}