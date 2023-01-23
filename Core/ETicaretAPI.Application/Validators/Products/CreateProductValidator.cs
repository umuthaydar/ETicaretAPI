using ETicaretAPI.Application.ViewModels.Products;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator() {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen ürün adını giriniz!")
                .MinimumLength(5)
                .MaximumLength(150)
                    .WithMessage("Lütfen 5 ile 150 karakter arasına isim giriniz!");
            
            RuleFor(s => s.Stock)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Stok bilgisi boş olamaz!")
                .Must(s => s >= 0)
                    .WithMessage("Stok bilgisi negatif değer olamaz!");

            RuleFor(s => s.Price)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Fiyat bilgisi boş olamaz!")
                .Must(s => s >= 0)
                    .WithMessage("Fiyat bilgisi negatif değer olamaz!");
        }
    }
}
