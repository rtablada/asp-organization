using System;
using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;

namespace MonolithApi.Models
{
    public class User : Identifiable<Guid>
    {
        [Attr] public string Email { get; set; }
        [Attr] public string Name { get; set; }
    }
}
