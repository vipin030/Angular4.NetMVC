import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { Observable } from 'rxjs/Observable';
//import {  } from 'rxjs';
import { CNN_URL } from '../util/url';

@Injectable()
export class RssService {
    constructor(private http: Http) {

    }
    getRssFeeds(item:string): Observable<any> {
        return this.http.get(CNN_URL+"?rssfeed="+item);
    }
}