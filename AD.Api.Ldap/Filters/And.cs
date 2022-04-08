using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Api.Ldap.Filters
{
    public sealed record And : FilterContainer
    {
        public override FilterType Type => FilterType.And;

        public And()
            : base(2)
        {
        }

        public sealed override void WriteTo(JsonWriter writer, NamingStrategy strategy, JsonSerializer serializer)
        {
            writer.WritePropertyName(nameof(And).ToLower());
            writer.WriteStartObject();

            base.WriteTo(writer, strategy, serializer);

            writer.WriteEndObject();
        }

        public sealed override StringBuilder WriteTo(StringBuilder builder)
        {
            builder.Append("(&");

            return base
                .WriteTo(builder)
                .Append((char)41);
        }
    }
}
