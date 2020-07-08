using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Viam.SalesForce.API.Data.Products;
using Viam.SalesForce.API.Model.Configuration;
using Viam.SalesForce.API.Model.Products;

namespace Viam.SalesForce.API.Business.Products
{
    public class ProductBusiness
    {
        ProductRepository _envioReadRepository;
        ProductRepository _envioWriteRepository;

        public ProductBusiness(ConfigurationModel configuration)
        {
            _envioReadRepository = new ProductRepository(configuration.EnvioRead);
            _envioWriteRepository = new ProductRepository(configuration.EnvioWrite);
        }

        public ActionResult<string> setProductStatus(string idbranch, string status, string flag)
        {
            return _envioReadRepository.setProductStatus(idbranch, status, flag);
        }

        public ActionResult<NewProductParams> addNewProduct(NewProductParams newProductParams)
        {
            return _envioWriteRepository.addNewProduct(newProductParams);
        }

        public ActionResult<ProductModel> getProduct(string idBranch)
        {
            return _envioReadRepository.getProduct(idBranch);
        }

        public ActionResult<ProductModel> updateProduct(ProductModel productModelUpdate)
        {
            ProductModel productModelToSave = new ProductModel();

            //productModelstored = _envioReadRepository.getProduct(productModel.idBranch).Value;
            //List<PropertyInfo> propertyInfos = GetDifferences(productModelstored, productModel);

            if (!string.IsNullOrWhiteSpace(productModelUpdate.idCompany))
            {
                productModelToSave.idCompany = productModelUpdate.idCompany;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.nameBranch))
            {
                productModelToSave.nameBranch = productModelUpdate.nameBranch;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.addressBranch))
            {
                productModelToSave.addressBranch = productModelUpdate.addressBranch;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.idCity))
            {
                productModelToSave.idCity = productModelUpdate.idCity;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.idMainBranch))
            {
                productModelToSave.idMainBranch = productModelUpdate.idMainBranch;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.idFlagBranch))
            {
                productModelToSave.idFlagBranch = productModelUpdate.idFlagBranch;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.idTypeBranch))
            {
                productModelToSave.idTypeBranch = productModelUpdate.idTypeBranch;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.phone1Branch))
            {
                productModelToSave.phone1Branch = productModelUpdate.phone1Branch;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.phone2Branch))
            {
                productModelToSave.phone2Branch = productModelUpdate.phone2Branch;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.faxBranch))
            {
                productModelToSave.faxBranch = productModelUpdate.faxBranch;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.dateCreateBranch.ToString()))
            {
                productModelToSave.dateCreateBranch = productModelUpdate.dateCreateBranch;
            }
            if (!string.IsNullOrEmpty(productModelUpdate.zipBranch.ToString()))
            {
                productModelToSave.zipBranch = productModelUpdate.zipBranch;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.currencyPayBranch))
            {
                productModelToSave.currencyPayBranch = productModelUpdate.currencyPayBranch;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.idStatusBranch))
            {
                productModelToSave.idStatusBranch = productModelUpdate.idStatusBranch;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.statusComment))
            {
                productModelToSave.statusComment = productModelUpdate.statusComment;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.businessHours))
            {
                productModelToSave.businessHours = productModelUpdate.businessHours;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.latitud))
            {
                productModelToSave.latitud = productModelUpdate.latitud;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.longitud))
            {
                productModelToSave.longitud = productModelUpdate.longitud;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.geoPrecision))
            {
                productModelToSave.geoPrecision = productModelUpdate.geoPrecision;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.idLocation))
            {
                productModelToSave.idLocation = productModelUpdate.idLocation;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.idChain))
            {
                productModelToSave.idChain = productModelUpdate.idChain;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.redphone.ToString()))
            {
                productModelToSave.redphone = productModelUpdate.redphone;
            }
            if (!string.IsNullOrEmpty(productModelUpdate.dateOpen.ToString()))
            {
                productModelToSave.dateOpen = productModelUpdate.dateOpen;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.nameMainBranch))
            {
                productModelToSave.nameMainBranch = productModelUpdate.nameMainBranch;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.dateCreaMainOpen.ToString()))
            {
                productModelToSave.dateCreaMainOpen = productModelUpdate.dateCreaMainOpen;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.emailBusiness))
            {
                productModelToSave.emailBusiness = productModelUpdate.emailBusiness;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.emailOwner))
            {
                productModelToSave.emailOwner = productModelUpdate.emailOwner;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.paymentMethod1))
            {
                productModelToSave.paymentMethod1 = productModelUpdate.paymentMethod1;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.paymentMethod2))
            {
                productModelToSave.paymentMethod2 = productModelUpdate.paymentMethod2;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.finSchedule))
            {
                productModelToSave.finSchedule = productModelUpdate.finSchedule;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.emailOperations))
            {
                productModelToSave.emailOperations = productModelUpdate.emailOperations;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.finYearlyInterestRate))
            {
                productModelToSave.finYearlyInterestRate = productModelUpdate.finYearlyInterestRate;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.finStatusComments))
            {
                productModelToSave.finStatusComments = productModelUpdate.finStatusComments;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.creditGrade))
            {
                productModelToSave.creditGrade = productModelUpdate.creditGrade;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.depositBank))
            {
                productModelToSave.depositBank = productModelUpdate.depositBank;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.idSalesForce))
            {
                productModelToSave.idSalesForce = productModelUpdate.idSalesForce;
            }
            if (!string.IsNullOrWhiteSpace(productModelUpdate.nameAgent))
            {
                productModelToSave.nameAgent = productModelUpdate.nameAgent;
            }

            return _envioWriteRepository.updateProduct(productModelToSave);
        }

        public List<PropertyInfo> GetDifferences(ProductModel test1, ProductModel test2)
        {
            List<PropertyInfo> differences = new List<PropertyInfo>();
            foreach (PropertyInfo property in test1.GetType().GetProperties())
            {
                object value1 = property.GetValue(test1, null);
                object value2 = property.GetValue(test2, null);
                if (!value1.Equals(value2))
                {
                    differences.Add(property);
                }
            }
            return differences;
        }

        public ActionResult<List<KpisModel>> getKpis(string name, string idProduct)
        {
            return _envioReadRepository.getKpis(name, idProduct);
        }
    }
}