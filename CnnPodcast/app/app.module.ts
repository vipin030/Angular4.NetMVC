import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppComponent } from './app';
import { RssService } from './providers/rss.service';

@NgModule({
    imports: [BrowserModule, FormsModule, ReactiveFormsModule, HttpModule],
    declarations: [AppComponent],
    providers: [RssService],
    bootstrap: [AppComponent]
})
export class AppModule { }