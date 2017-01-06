using System;
using System.IO;

namespace EW.Unisystems.Common.DTOS
{
    public class NewsDTO<T>
    {
        public int NewsId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Resume { get; set; }
        public DateTime DateRegister { get; set; }
        public string Author { get; set; }
        public T Image { get; set; }
    }

    public class EventDTO
    {
        public int EventId { get; set; }
        public DateTime DateEvent { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Time { get; set; }
        public string Location { get; set; }
    }

    public class ProductDTO<T>
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public T Image { get; set; }
    }

    public class BookDTO<T>
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Resume { get; set; }
        public string PathDownload { get; set; }
        public T Image { get; set; }
    }

    public class VideoDTO<T>
    {
        public int VideoId { get; set; }
        public string Title { get; set; }
        public string Resume { get; set; }
        public T Image { get; set; }
        public string Author { get; set; }
    }

    public class ResourceDTO<T>
    {
        public int ResourceId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int TypeResource { get; set; }
        public T Image { get; set; }
        public string ResourceLink { get; set; }
        public int Career { get; set; }
        public string NameCareer { get; set; }
        public string NameTypeResource { get; set; }
    }

    public class ImageDTO
    {
        public string IdImage { get; set; }
        public string Name { get; set; }
        public Stream Image { get; set; }
    }
}