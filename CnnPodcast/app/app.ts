import { Component } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Meta, Title } from '@angular/platform-browser';
import { RssService } from './providers/rss.service';
import { FeedType } from './interfaces/rss.interface';

@Component({
    selector: 'betsson-app',
    templateUrl: 'app/app.component.html',
    styleUrls: ['app/app.component.css']
})

export class AppComponent {
    public rssFeeds: FeedType;
    public page:any = { "title": "CNN Podcast", "decsription": "CNN PODCAST offer live news", "auther": "Betsson.com", "keywords": "Betsson cnn news, Betsson live, Betsson news online"};
    public rssCategory:string[] = ["edition", "edition_world", "edition_africa", "edition_americas",
        "edition_asia", "edition_europe", "edition_meast", "edition_us", "edition_technology", "edition_space",
        "edition_entertainment", "edition_sport", "edition_football", "edition_golf", "edition_motorsport", "edition_tennis",
        "edition_travel", "cnn_freevideo", "cnn_latest"
    ];
    cnnForm: FormGroup;
    constructor(private fb: FormBuilder, private meta: Meta, private title: Title, private rssService: RssService) {
        this.cnnForm = this.fb.group({
            category: 'edition'
        });
        this.getRssFeeds(this.rssCategory[0]);
        this.cnnForm.controls['category'].valueChanges.subscribe((value) => {
            console.log("Changed value:", value);
            this.getRssFeeds(value);
        });
        this.setSiteSEO(this.page);
    }
    getRssFeeds(item:string) {
        this.rssService.getRssFeeds(item).subscribe(response => {
            this.rssFeeds = response.json();
            //console.log("Rss feeds", this.rssFeeds);
        });
    }

    setSiteSEO(data: any) {
        this.title.setTitle(data.title);
        this.meta.addTags([
            { name: 'auther', content: data.auther },
            { name: 'keyword', content: data.keywords },
            { name: 'description', content: data.description }
        ])
    }

}