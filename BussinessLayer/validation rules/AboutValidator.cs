﻿using EntityLayer.concerete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.validation_rules
{
    public class AboutValidator:AbstractValidator<About>
    {

        public AboutValidator() 
        {
            RuleFor(x=>x.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz");

            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen görsel seçiniz");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("Lütfen 50 karakterlik açıklama bilgisi giriniz.");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("lütfen açıklamayı kısaltın");


        }


    }
}
