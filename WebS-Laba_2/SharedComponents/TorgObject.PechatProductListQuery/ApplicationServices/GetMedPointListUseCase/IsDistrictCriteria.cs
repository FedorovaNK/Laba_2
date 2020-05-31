using TorgObject.DomainObjects;
using TorgObject.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace TorgObject.ApplicationServices.GetMedPointListUseCase
{
    public class IsDistrictCriteria : ICriteria<MedPoint>
    {
        public string IsDistrict { get; }

        public IsDistrictCriteria(string isDistrict)
            => IsDistrict = isDistrict;

        public Expression<Func<MedPoint, bool>> Filter
            => (d => d.IsDistrict == IsDistrict);
    }
}
