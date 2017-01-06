using System;
using System.Collections.Generic;
using System.Linq;
using EW.Unisystems.Data.Repositories;
using EW.Unisystems.Common.DTOS;
using EW.Unisystems.Data;

namespace EW.Unisystems.Services.Services
{
    public class NewsService
    {
        private NewsRepository _newsRepository;

        public NewsService()
        {
            _newsRepository = new NewsRepository();
        }

        public bool SaveNews(NewsDTO<string> news)
        {
            try
            {
                var newsEntity = new News() { Image = null, Title = news.Title, Content = news.Resume, DateNews = DateTime.Now};
                _newsRepository.Add(newsEntity);
                _newsRepository.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<NewsDTO<string>> GetListNews()
        {
            try
            {
                var news = _newsRepository.GetMany(x => x.IdNews > 0);

                return news.Select(x => new NewsDTO<string>()
                {
                    Title = x.Title,
                    Content = x.Content,
                    DateRegister = x.DateNews
                }).ToList();
            }
            catch (Exception)
            {
                return new List<NewsDTO<string>>();
            }
        }
    }
}