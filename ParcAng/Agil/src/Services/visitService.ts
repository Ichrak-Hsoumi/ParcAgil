import { HttpClient } from "@angular/common/http";
import { Inject } from "@angular/core";
import { Observable } from "rxjs";


export class VisitService {
    appurl: string = "";

    constructor(private httpobj: HttpClient, @Inject('BASE_URL') _baseurl: string) {
        this.appurl = _baseurl;
    }

    getAllVisites(): Observable<VisitModel> {
        return this.httpobj.get<VisitModel>(this.appurl + "api/Visite");
    }
}

export class VisitModel {
    id: number;
    dateVisite: Date;
    dateExpiration: Date;
    vehiculeId: string;
}