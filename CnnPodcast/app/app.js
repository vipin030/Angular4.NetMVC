"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var forms_1 = require("@angular/forms");
var platform_browser_1 = require("@angular/platform-browser");
var rss_service_1 = require("./providers/rss.service");
var AppComponent = (function () {
    function AppComponent(fb, meta, title, rssService) {
        var _this = this;
        this.fb = fb;
        this.meta = meta;
        this.title = title;
        this.rssService = rssService;
        this.page = { "title": "CNN Podcast", "decsription": "CNN PODCAST offer live news", "auther": "Betsson.com", "keywords": "Betsson cnn news, Betsson live, Betsson news online" };
        this.rssCategory = ["edition", "edition_world", "edition_africa", "edition_americas",
            "edition_asia", "edition_europe", "edition_meast", "edition_us", "edition_technology", "edition_space",
            "edition_entertainment", "edition_sport", "edition_football", "edition_golf", "edition_motorsport", "edition_tennis",
            "edition_travel", "cnn_freevideo", "cnn_latest"
        ];
        this.cnnForm = this.fb.group({
            category: 'edition'
        });
        this.getRssFeeds(this.rssCategory[0]);
        this.cnnForm.controls['category'].valueChanges.subscribe(function (value) {
            console.log("Changed value:", value);
            _this.getRssFeeds(value);
        });
        this.setSiteSEO(this.page);
    }
    AppComponent.prototype.getRssFeeds = function (item) {
        var _this = this;
        this.rssService.getRssFeeds(item).subscribe(function (response) {
            _this.rssFeeds = response.json();
            //console.log("Rss feeds", this.rssFeeds);
        });
    };
    AppComponent.prototype.setSiteSEO = function (data) {
        this.title.setTitle(data.title);
        this.meta.addTags([
            { name: 'auther', content: data.auther },
            { name: 'keyword', content: data.keywords },
            { name: 'description', content: data.description }
        ]);
    };
    return AppComponent;
}());
AppComponent = __decorate([
    core_1.Component({
        selector: 'betsson-app',
        templateUrl: 'app/app.component.html',
        styleUrls: ['app/app.component.css']
    }),
    __metadata("design:paramtypes", [forms_1.FormBuilder, platform_browser_1.Meta, platform_browser_1.Title, rss_service_1.RssService])
], AppComponent);
exports.AppComponent = AppComponent;
//# sourceMappingURL=app.js.map