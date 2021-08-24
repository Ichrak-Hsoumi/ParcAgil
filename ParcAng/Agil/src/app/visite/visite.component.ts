import { Component, OnInit } from '@angular/core';
import { VisitModel, VisitService } from '../../Services/visitService';

@Component({
  selector: 'app-visite',
  templateUrl: './visite.component.html',
  styleUrls: ['./visite.component.css']
})
export class VisiteComponent implements OnInit {

    public vislist: VisitModel;

    constructor(private serviceVisite: VisitService) {
        this.getAllVisites();
    }

  ngOnInit(): void {
  }

    getAllVisites() {
        this.serviceVisite.getAllVisites().subscribe(data => this.vislist = data);
    }

}
