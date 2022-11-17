using BussinesLogic.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Validators
{
    public class PhoneValidator : AbstractValidator<PhoneDto>
    {
        public PhoneValidator()
        {
            RuleFor(x => x.Model)
                .NotNull()
                .NotEmpty()
                .Length(3, 50);
            RuleFor(x => x.Screen)
                .NotNull()
                .NotEmpty()
                .Length(3, 20);
            RuleFor(x => x.RAM)
                .NotNull()
                .GreaterThanOrEqualTo(1);
            RuleFor(x => x.Storage)
                .NotNull()
                .GreaterThanOrEqualTo(1);
            RuleFor(x => x.Camera)
                .NotNull()
                .NotEmpty()
                .Length(3, 150);
            RuleFor(x => x.Price)
                .NotNull()
                .GreaterThanOrEqualTo(0);
            RuleFor(x => x.Battery)
                .NotNull()
                .GreaterThanOrEqualTo(1);
            RuleFor(x => x.ImagePath)
                .NotNull()
                .NotEmpty()
                .Must(LinkMustBeAUri).WithMessage("Link '{PropertyValue}' must be a valid URL.");
        }

        private static bool LinkMustBeAUri(string link)
        {
            if (string.IsNullOrWhiteSpace(link)) return false;

            Uri outUri;
            return Uri.TryCreate(link, UriKind.Absolute, out outUri)
                   && (outUri.Scheme == Uri.UriSchemeHttp || outUri.Scheme == Uri.UriSchemeHttps);
        }
    }
}
