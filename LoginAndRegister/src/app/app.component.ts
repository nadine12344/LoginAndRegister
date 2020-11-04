import { Component, OnInit } from '@angular/core';
import { DataService } from './shared/dataService';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  _listFilter = '';
  products: any[]=[];
  filtered: any[] = this.products;
  get listFilter(): string {
    return this._listFilter;
  }
  set listFilter(value: string) {
    this._listFilter = value;
    this.filtered = this.listFilter ? this.performFilter(this.listFilter) : this.products;
  }
  performFilter(filterBy: string): any[] {
    filterBy = filterBy.toLocaleLowerCase();
    return this.products.filter((product) =>
      product.roles.some(e => e.toLocaleLowerCase().indexOf(filterBy) !== -1));
  }
  constructor(private data: DataService) {
    
  }
  ngOnInit(): void {

      this.data.loadProducts().subscribe(success => {
        if (success) {
          this.products = this.data.products;
          this.filtered = this.products;

        }
        });
    }
  title = 'client';
}
