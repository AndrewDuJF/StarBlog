﻿using StarBlog.Data.Models;

namespace StarBlog.Web.ViewModels;

public class HomeViewModel {
    /// <summary>
    /// 随机图片
    /// </summary>
    public Photo? RandomPhoto { get; set; }

    /// <summary>
    /// 是否显示 Chart
    /// </summary>
    public bool ChartVisible { get; set; } = false;

    /// <summary>
    /// 置顶博客
    /// </summary>
    public Post? TopPost { get; set; }

    /// <summary>
    /// 推荐博客
    /// </summary>
    public List<Post> FeaturedPosts { get; set; } = new();

    /// <summary>
    /// 推荐照片，原则上只能三个
    /// </summary>
    public List<Photo> FeaturedPhotos { get; set; } = new();

    /// <summary>
    /// 推荐分类，原则上三个
    /// </summary>
    public List<FeaturedCategory> FeaturedCategories { get; set; } = new();

    /// <summary>
    /// 友情链接
    /// </summary>
    public List<Link> Links { get; set; } = new();
}