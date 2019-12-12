using Satici.Business.Abstract;
using Satici.Business.DependencyResolvers.Ninject;
using Satici.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Satici.WebAPI.Controllers
{
    public class KategoriController : ApiController
    {
        IKategoriService _kategoriService;
        public KategoriController()
        {
            _kategoriService = InstanceFactory.GetInstance<IKategoriService>();
        }
        public IHttpActionResult GetAllKategori()
        {
            var kategoriler = _kategoriService.GetAll();
            if (kategoriler == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(kategoriler);
            }
        }


        public IHttpActionResult PostKategori(Kategori kategori)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Hatalı Veri!");
            }
            else
            {
                try
                {
                    _kategoriService.Add(kategori);
                    return Content(HttpStatusCode.Created, "Created");
                }
                catch
                {

                    return InternalServerError();
                }
            }
        }
        public IHttpActionResult PutKategori(Kategori kategori)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Hatalı Veri!");
            }
            else
            {
                try
                {
                    if (_kategoriService.Exist(kategori))
                    {
                        _kategoriService.Update(kategori);
                        return Ok();
                    }
                    else
                    {
                        return BadRequest();
                    }
                  
                }
                catch
                {

                    return InternalServerError();
                }
            }
        }

        public IHttpActionResult DeleteKategori(Kategori kategori)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Hatalı Veri!");
            }
            else
            {
                try
                {
                    if (_kategoriService.Exist(kategori))
                    {
                        _kategoriService.Delete(kategori);
                        return StatusCode(HttpStatusCode.NoContent);
                    }
                    else
                    {
                        return BadRequest();
                    }

                }
                catch
                {

                    return InternalServerError();
                }
            }
        }
    }
}
